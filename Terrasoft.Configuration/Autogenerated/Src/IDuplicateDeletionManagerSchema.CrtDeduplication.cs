namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicateDeletionManagerSchema

	/// <exclude/>
	public class IDuplicateDeletionManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicateDeletionManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicateDeletionManagerSchema(IDuplicateDeletionManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2");
			Name = "IDuplicateDeletionManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,177,78,195,48,16,157,27,169,255,112,10,11,72,40,217,219,144,133,32,148,161,8,21,152,16,131,27,95,130,165,218,14,103,187,82,84,241,239,184,78,26,210,8,225,201,247,238,222,187,167,119,138,73,52,45,171,16,94,145,136,25,93,219,228,94,171,90,52,142,152,21,90,37,5,114,215,238,69,21,170,101,116,92,70,11,103,132,106,224,165,51,22,229,122,25,121,228,138,176,241,109,40,149,69,170,189,220,10,202,98,160,97,129,123,60,145,55,76,177,6,41,16,210,52,133,204,56,41,25,117,249,80,143,4,224,3,35,57,79,166,147,209,214,237,252,24,136,243,170,255,54,45,142,97,219,232,111,131,246,83,115,179,130,231,32,210,55,231,94,2,176,69,169,15,104,128,176,210,196,13,212,164,165,247,53,201,2,56,179,44,25,5,210,185,66,214,50,98,18,148,79,248,46,70,101,133,237,158,252,63,206,31,194,63,52,146,44,13,83,127,147,156,18,95,14,183,193,65,201,77,156,191,5,96,240,4,204,31,172,187,80,56,104,193,33,132,128,215,198,210,233,74,191,139,111,225,209,9,254,254,1,51,217,155,245,144,17,42,222,199,20,234,239,254,176,23,160,199,166,239,7,187,107,149,157,61,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2"));
		}

		#endregion

	}

	#endregion

}

