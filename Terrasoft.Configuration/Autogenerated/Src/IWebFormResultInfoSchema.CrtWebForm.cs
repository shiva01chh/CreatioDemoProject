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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,49,107,195,48,16,133,231,4,252,31,14,178,22,107,79,76,150,210,6,15,129,208,6,58,203,242,201,17,216,82,184,147,18,74,232,127,175,44,55,142,27,74,91,45,226,157,222,125,122,210,89,217,33,31,165,66,216,35,145,100,167,125,254,232,172,54,77,32,233,141,179,217,252,146,205,179,249,108,65,216,68,9,165,245,72,58,54,44,161,124,195,234,217,81,247,130,28,90,95,90,237,146,83,8,1,5,135,174,147,244,190,254,210,59,114,39,83,35,131,185,182,131,118,4,103,172,250,189,3,74,136,120,218,171,116,111,126,37,137,9,234,24,170,214,168,9,228,167,8,179,33,240,152,120,139,254,224,106,94,194,46,117,15,135,247,33,83,97,131,158,65,194,73,182,1,227,37,181,81,49,138,109,224,124,136,8,164,49,37,3,7,165,144,57,31,81,226,158,85,36,202,40,1,10,181,246,20,176,16,106,13,70,95,9,43,112,61,250,108,24,31,122,139,150,45,39,207,4,125,35,85,206,181,240,58,116,194,5,26,244,43,248,248,235,65,145,15,113,182,241,187,227,168,89,54,248,255,212,251,95,90,111,78,246,212,255,210,83,111,220,14,190,187,112,11,180,245,48,141,164,135,234,247,98,170,77,215,39,4,133,255,205,154,2,0,0 };
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

