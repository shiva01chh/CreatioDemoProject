namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Terrasoft.Common;
    using Terrasoft.Configuration.PortalMessageFeed;
    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.Factories;

    #region Class: PortalMessagesActualizer

    /// <inheritdoc />
    [DefaultBinding(typeof(IPortalMessagesActualizer))]
    public class PortalMessagesActualizer: IPortalMessagesActualizer {

        #region Fields: Private

        private readonly UserConnection _userConnection;
        private readonly int _chunkSize = 1000;
        private readonly int _maxDegreeOfParallelism = 10;
        
        #endregion
        
        #region Constuctors: Public
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public PortalMessagesActualizer(UserConnection userConnection) {
            _userConnection = userConnection;
        }

        #endregion

        #region Methods: Private

        private void ValidateDatePeriod(DateTime dateFrom, DateTime dateTo) {
            if (dateFrom.Date > dateTo.Date || dateFrom.Date > DateTime.Today) {
                var message = new LocalizableString(_userConnection.Workspace.ResourceStorage,
                    "PortalMessagesActualizer", "LocalizableStrings.InputPeriodInvalidCaption.Value");
                throw new Exception(message);
            }
        }

        private List<Guid> GetMessageIdsToActualize(DateTime dateFrom, DateTime dateTo) {
            var result = new List<Guid>();
            Select select = new Select(_userConnection)
                    .Column("Id")
                .From("PortalMessage")
                .Where("HideOnPortal").IsEqual(Column.Parameter(false))
                    .And("ModifiedOn").IsGreaterOrEqual(Column.Parameter(dateFrom.Date))
                    .And("ModifiedOn").IsLess(Column.Parameter(dateTo.Date.AddDays(1)))
                    .And("PortalMessage", "Id").Not().In(
                    new Select(_userConnection)
                                .Column("Id")
                            .From("SocialMessage")) as Select;
            select.ExecuteReader(dr => result.Add(dr.GetColumnValue<Guid>("Id")));
            return result;
        }
        
        private List<Guid> GetFileIdsToActualize(List<Guid> portalMessagesIds) {
            if (!portalMessagesIds.Any()) {
                return new List<Guid>();
            }
            var result = new List<Guid>();
                Select select = new Select(_userConnection)
                    .Column("Id")
                    .From("PortalMessageFile")
                    .Where("PortalMessageId").In(Column.Parameters(portalMessagesIds)) as Select;
                select.ExecuteReader(dr => result.Add(dr.GetColumnValue<Guid>("Id")));
            return result;
        }

        private void ActualizeData(List<Guid> ids, Action<List<Guid>> actualizeFunc) {
            var parts = new List<IEnumerable<Guid>>(ids.SplitOnChunks(_chunkSize));
            Parallel.For(0, parts.Count, new ParallelOptions { MaxDegreeOfParallelism = _maxDegreeOfParallelism },
                i => {
                    actualizeFunc(parts[i].ToList());
                });
        }
        
        private void ActualizeMessagesChunk(List<Guid> ids) {
            if (ids.Any()) {
                InsertSelect insertSelect = new InsertSelect(_userConnection)
                    .Into("SocialMessage")
                    .Set(
                        "Id",
                        "CreatedOn",
                        "CreatedById",
                        "ModifiedOn",
                        "ModifiedById",
                        "EntityId",
                        "EntitySchemaUId",
                        "Message",
                        "UserAccess"
                    ).FromSelect(
                        new Select(_userConnection)
                            .Column("Id")
                            .Column("CreatedOn")
                            .Column("CreatedById")
                            .Column("ModifiedOn")
                            .Column("ModifiedById")
                            .Column("EntityId")
                            .Column("EntitySchemaUId")
                            .Column("Message")
                            .Column(Column.Const(1))
                            .From("PortalMessage")
                            .Where("Id").In(Column.Parameters(ids)));
                insertSelect.Execute();
            }
        }
        
        private void ActualizeFilesChunk(List<Guid> ids) {
            if (ids.Any()) {
                InsertSelect insertSelect = new InsertSelect(_userConnection)
                    .Into("SysFile")
                    .Set(
                        "Id",
                        "CreatedOn",
                        "CreatedById",
                        "ModifiedOn",
                        "ModifiedById",
                        "Name",
                        "Data",
                        "TypeId",
                        "Version",
                        "Size",
                        "SysFileStorageId",
                        "RecordSchemaName",
                        "RecordId",
                        "FileGroupId"
                    ).FromSelect(
                        new Select(_userConnection)
                            .Column("Id")
                            .Column("CreatedOn")
                            .Column("CreatedById")
                            .Column("ModifiedOn")
                            .Column("ModifiedById")
                            .Column("Name")
                            .Column("Data")
                            .Column("TypeId")
                            .Column("Version")
                            .Column("Size")
                            .Column("SysFileStorageId")
                            .Column(Column.Const("SocialMessage"))
                            .Column("PortalMessageId")
                            .Column("FileGroupId")
                            .From("PortalMessageFile")
                            .Where("Id").In(Column.Parameters(ids)));
                insertSelect.Execute();
            }
        }

        #endregion

        #region Methods: Public

        /// <inheritdoc />
        public void ActualizePortalMessages(DateTime dateFrom, DateTime dateTo) {
            ValidateDatePeriod(dateFrom, dateTo);
            List<Guid> messagesToActualizeIds = GetMessageIdsToActualize(dateFrom, dateTo);
            ActualizeData(messagesToActualizeIds, ActualizeMessagesChunk);
            List<Guid> filesToActualizeIds = GetFileIdsToActualize(messagesToActualizeIds);
            ActualizeData(filesToActualizeIds, ActualizeFilesChunk);
        }

        #endregion
        
    }
    
    #endregion
}




