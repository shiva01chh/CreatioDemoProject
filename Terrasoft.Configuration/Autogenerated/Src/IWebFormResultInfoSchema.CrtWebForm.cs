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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,49,107,195,48,16,133,231,4,242,31,14,178,150,120,79,76,150,210,6,15,129,208,6,58,203,242,201,17,216,82,184,147,98,74,232,127,175,36,215,142,27,74,91,45,226,157,222,125,122,210,25,209,34,159,133,68,56,34,145,96,171,220,234,209,26,165,107,79,194,105,107,22,243,235,98,190,152,207,150,132,117,144,80,24,135,164,66,195,26,138,55,44,159,45,181,47,200,190,113,133,81,54,57,179,44,131,156,125,219,10,122,223,126,233,3,217,139,174,144,65,15,237,160,44,65,135,101,220,91,160,132,8,167,81,165,123,87,3,41,155,160,206,190,108,180,156,64,126,138,48,235,3,143,137,247,232,78,182,226,53,28,82,119,127,120,31,50,21,118,232,24,4,92,68,227,49,92,82,105,25,162,152,26,186,83,64,32,141,41,25,216,75,137,204,171,17,149,221,179,242,68,25,37,64,46,183,142,60,230,153,220,130,86,3,97,3,54,162,59,205,248,16,45,74,52,156,60,19,244,141,84,90,219,192,107,223,9,87,168,209,109,224,227,175,7,5,62,132,217,134,239,14,163,102,81,227,255,83,31,127,105,189,57,217,81,252,165,167,104,220,247,190,187,112,75,52,85,63,141,164,251,234,247,98,170,197,245,9,167,105,131,224,146,2,0,0 };
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

