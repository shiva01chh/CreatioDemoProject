namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityChunkDataSchema

	/// <exclude/>
	public class EntityChunkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityChunkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityChunkDataSchema(EntityChunkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2514f3cc-6ad8-4976-a835-7cf0143ff738");
			Name = "EntityChunkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,191,78,195,48,16,135,231,86,234,59,88,237,2,75,30,128,2,75,8,168,3,40,34,72,12,21,131,227,94,83,11,255,137,206,246,80,34,222,157,179,77,43,74,105,69,134,68,119,254,125,247,57,103,184,6,215,115,1,236,5,16,185,179,107,95,148,214,172,101,23,144,123,105,77,113,47,21,44,116,111,209,79,198,195,100,60,10,78,154,142,53,91,231,65,207,127,213,132,42,5,34,114,174,120,0,3,40,197,81,230,57,24,47,53,20,13,157,114,37,63,146,134,82,148,155,33,116,84,48,86,42,238,220,21,171,40,233,183,229,38,152,247,59,238,121,202,44,247,92,171,224,141,26,125,104,149,20,76,68,228,152,24,13,137,218,143,174,209,246,128,94,2,141,175,19,153,207,151,49,254,8,186,5,188,120,162,165,176,27,54,133,56,140,146,211,203,232,217,137,22,149,9,26,48,234,175,243,98,178,148,96,2,236,109,190,3,97,108,96,29,248,57,115,241,245,121,90,227,130,16,224,28,221,44,126,96,245,253,15,150,246,116,104,150,198,179,230,116,248,191,190,126,199,190,74,191,169,16,45,158,53,214,231,226,127,57,103,96,86,121,219,169,206,221,195,102,234,253,124,190,0,77,25,24,155,136,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2514f3cc-6ad8-4976-a835-7cf0143ff738"));
		}

		#endregion

	}

	#endregion

}

