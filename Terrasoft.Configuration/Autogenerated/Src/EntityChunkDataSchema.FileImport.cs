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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,61,79,195,48,16,134,231,86,234,127,176,218,5,150,252,0,10,44,33,160,14,160,136,32,49,84,12,142,123,77,45,252,17,157,237,161,68,252,119,206,54,173,84,250,33,50,36,186,243,251,220,227,156,225,26,92,207,5,176,55,64,228,206,174,125,81,90,179,150,93,64,238,165,53,197,163,84,176,208,189,69,63,25,15,147,241,40,56,105,58,214,108,157,7,61,255,83,19,170,20,136,200,185,226,9,12,160,20,71,153,215,96,188,212,80,52,116,202,149,252,74,26,74,81,110,134,208,81,193,88,169,184,115,55,172,162,164,223,150,155,96,62,31,184,231,41,179,220,115,173,130,15,106,244,161,85,82,48,17,145,99,98,52,36,106,63,186,70,219,3,122,9,52,190,78,100,62,95,198,248,51,232,22,240,234,133,150,194,238,216,20,226,48,74,78,175,163,103,39,90,84,38,104,192,168,191,205,139,201,82,130,9,176,247,249,14,132,177,129,117,224,231,204,197,215,247,121,141,11,66,128,115,116,179,248,129,213,239,63,88,218,211,161,89,26,207,154,243,225,255,250,250,29,251,46,253,166,66,180,120,209,88,95,138,159,114,206,192,172,242,182,83,157,187,135,205,212,139,207,15,75,67,41,133,128,2,0,0 };
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

