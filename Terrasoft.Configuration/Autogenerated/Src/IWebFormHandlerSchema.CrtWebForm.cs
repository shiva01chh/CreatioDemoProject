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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,177,106,195,48,16,134,231,24,252,14,71,178,180,139,181,167,110,150,148,180,30,2,161,13,116,86,172,147,35,176,36,115,146,13,161,244,221,43,203,118,234,164,84,147,116,124,223,221,175,51,92,163,107,120,137,112,68,34,238,172,244,217,214,26,169,170,150,184,87,214,164,201,87,154,44,90,167,76,245,31,146,189,162,193,112,69,241,137,167,157,37,253,129,212,169,18,159,210,36,168,43,194,42,64,80,24,143,36,195,164,53,20,35,247,198,141,168,145,34,198,24,131,220,181,90,115,186,108,198,247,129,108,167,4,58,80,147,11,19,201,102,104,211,158,106,85,206,160,187,254,191,3,223,209,181,181,47,140,180,65,235,255,117,77,183,71,127,182,194,173,225,16,155,197,72,127,50,197,194,208,212,129,63,35,200,208,19,4,247,60,187,226,236,158,207,27,78,92,131,9,139,126,94,246,194,75,224,151,155,227,141,158,179,72,69,169,179,74,140,83,250,204,15,187,209,129,73,126,28,22,187,88,161,17,67,252,248,254,30,214,125,83,140,181,249,249,1,93,98,56,64,240,1,0,0 };
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

