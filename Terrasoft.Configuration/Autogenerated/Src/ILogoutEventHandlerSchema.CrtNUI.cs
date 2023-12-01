namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILogoutEventHandlerSchema

	/// <exclude/>
	public class ILogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILogoutEventHandlerSchema(ILogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863");
			Name = "ILogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,205,106,195,48,12,128,207,43,244,29,68,118,217,46,241,189,77,123,25,131,21,54,232,161,123,0,215,81,82,131,127,130,100,103,140,178,119,159,234,180,101,45,203,41,150,165,79,159,165,160,61,242,160,13,194,14,137,52,199,46,213,47,49,116,182,207,164,147,141,97,62,59,206,103,15,153,109,232,111,82,8,151,243,153,220,60,18,246,146,6,155,144,144,58,1,45,96,243,30,251,152,211,235,136,33,189,233,208,58,164,146,170,148,130,134,179,247,154,190,215,231,243,150,226,104,91,100,208,131,133,46,18,84,194,202,140,4,174,64,42,208,230,164,193,96,253,224,208,11,178,104,213,23,158,250,3,28,242,222,89,3,246,162,242,159,9,28,139,203,213,251,3,211,33,182,188,128,109,41,158,46,239,77,75,96,119,176,12,190,164,195,151,117,14,246,8,70,59,135,173,252,137,58,78,222,140,204,39,48,134,86,76,64,18,238,212,185,190,182,80,247,61,154,65,147,246,16,100,43,171,42,155,106,221,48,74,23,194,110,85,125,10,93,86,19,176,12,164,82,107,193,115,210,193,96,221,168,82,87,48,99,180,45,76,143,45,239,126,186,173,131,108,158,151,231,17,136,226,52,133,114,254,153,246,121,19,148,152,124,191,93,154,210,215,37,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863"));
		}

		#endregion

	}

	#endregion

}

