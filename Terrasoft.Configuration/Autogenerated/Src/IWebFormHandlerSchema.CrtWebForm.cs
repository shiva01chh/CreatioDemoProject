namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormHandlerSchema

	/// <exclude/>
	public class IWebFormHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormHandlerSchema(IWebFormHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85b340bd-4e82-4d09-9c7d-737d1496c5d3");
			Name = "IWebFormHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,177,78,195,48,16,134,231,70,202,59,156,218,5,150,120,47,161,75,81,33,3,82,5,149,152,221,248,156,90,138,237,232,108,71,66,136,119,199,113,146,210,22,225,201,62,125,223,221,239,51,92,163,235,120,141,112,64,34,238,172,244,197,214,26,169,154,64,220,43,107,242,236,43,207,22,193,41,211,252,135,20,207,104,48,94,81,124,224,113,103,73,191,35,245,170,198,135,60,139,234,138,176,137,16,84,198,35,201,56,105,13,213,196,189,112,35,90,164,132,49,198,160,116,65,107,78,159,155,233,189,39,219,43,129,14,212,236,194,76,178,11,180,11,199,86,213,23,208,77,255,223,129,111,232,66,235,43,35,109,212,134,127,157,211,189,162,63,89,225,214,176,79,205,82,164,63,153,82,97,108,234,192,159,16,100,236,9,130,123,94,156,113,118,203,151,29,39,174,193,196,69,63,46,7,225,41,242,203,205,225,74,47,89,162,146,212,91,37,166,41,67,230,187,221,228,192,44,223,143,139,93,172,208,136,49,126,122,127,143,235,190,42,166,218,112,126,0,240,159,88,164,232,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85b340bd-4e82-4d09-9c7d-737d1496c5d3"));
		}

		#endregion

	}

	#endregion

}

