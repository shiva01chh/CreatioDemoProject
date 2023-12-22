namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Linq;
    using Terrasoft.Common;
    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;

    #region Class: OpportunityMoodEventListener

    /// <summary>
    /// Handler for OpportunityMood entity events.
    /// </summary>
    /// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
    [EntityEventListener(SchemaName = "OpportunityMood")]
    public class OpportunityMoodEventListener : BaseEntityEventListener
    {

        #region Fields: Private

        private UserConnection _userConnection;

        private readonly List<string> _columnNames = new List<string>() {
            "Name",
            "Data",
            "MimeType"
        };

        private string SysImageSchemaName = "SysImage";

        #endregion
        
        #region Methods: Private

        private Select GetSelectQuery(Guid id) {
            var select = new Select(_userConnection)
                .Column(Column.Const(id))
                .From(SysImageSchemaName).Where("Id")
                .IsEqual(Column.Parameter(OpportunityConstants.DefaulMoodImageId)) as Select;
            foreach (var column in _columnNames) {
                select.Column(column);
            }
            return select;
        }
        
        #endregion

        #region Methods: Protected

        protected virtual void CopyImageRecord(Entity entity) {
            if (entity.GetColumnValue("ImageId") != null) {
                return;
            }
            Guid id = Guid.NewGuid();
            List<string> columnNames = new List<string>() {
                "Id"
            };
            columnNames.AddRange(_columnNames);
            try {
                var insertSelect = new InsertSelect(_userConnection)
                    .Into(SysImageSchemaName)
                    .Set(columnNames)
                    .FromSelect(GetSelectQuery(id));
                insertSelect.Execute();
            } catch (DbException dbException) {
                string errorMessage = _userConnection.DBEngine.FormatException(dbException);
                throw new DbOperationException(errorMessage, dbException);
            }
            entity.SetColumnValue("ImageId", id);
        }

        #endregion

        #region Methods: Public

        /// <inheritdoc />
        public override void OnInserting(object sender, EntityBeforeEventArgs e) {
            base.OnInserting(sender, e);
            var entity = (Entity)sender;
            _userConnection = entity.UserConnection;
            CopyImageRecord(entity);
        }

        #endregion

    } 

    #endregion

}













