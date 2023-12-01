namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormResultInfoSchema

	/// <exclude/>
	public class IWebFormResultInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormResultInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormResultInfoSchema(IWebFormResultInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30bc9300-f8d4-4de5-89f5-8558b24e931e");
			Name = "IWebFormResultInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,49,107,195,48,16,133,231,24,252,31,14,178,22,123,79,140,151,210,134,12,129,208,6,58,203,242,201,17,216,82,184,147,18,74,232,127,175,44,215,142,27,74,91,45,226,157,222,125,122,210,25,209,33,159,132,68,56,32,145,96,171,92,246,104,141,210,141,39,225,180,53,105,114,77,147,52,89,44,9,155,32,97,107,28,146,10,13,43,216,190,97,245,108,169,123,65,246,173,219,26,101,163,51,207,115,40,216,119,157,160,247,242,75,239,201,158,117,141,12,122,108,7,101,9,46,88,245,123,7,20,17,225,180,87,241,222,108,36,229,51,212,201,87,173,150,51,200,79,17,22,67,224,41,241,14,221,209,214,188,130,125,236,30,14,239,67,198,194,6,29,131,128,179,104,61,134,75,106,45,67,20,211,192,229,24,16,72,83,74,6,246,82,34,115,54,161,242,123,86,17,41,147,4,40,100,233,200,99,145,203,18,180,26,9,107,176,61,250,162,25,31,122,139,18,45,71,207,12,125,35,85,214,182,240,58,116,194,21,26,116,107,248,248,235,65,129,15,97,182,225,187,195,168,89,52,248,255,212,135,95,90,111,78,118,212,255,210,83,111,220,13,190,187,112,75,52,245,48,141,168,135,234,247,98,172,133,245,9,38,201,234,89,145,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30bc9300-f8d4-4de5-89f5-8558b24e931e"));
		}

		#endregion

	}

	#endregion

}

