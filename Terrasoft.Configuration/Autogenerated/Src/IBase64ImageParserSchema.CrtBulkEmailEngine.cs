namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBase64ImageParserSchema

	/// <exclude/>
	public class IBase64ImageParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBase64ImageParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBase64ImageParserSchema(IBase64ImageParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0");
			Name = "IBase64ImageParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,193,74,195,64,16,134,207,22,250,14,67,122,81,144,228,34,30,180,205,65,17,12,88,144,218,23,216,198,217,184,176,217,13,51,187,150,34,190,187,147,164,169,129,22,10,186,151,176,195,204,55,255,63,147,117,170,70,110,84,137,176,70,34,197,94,135,244,209,59,109,170,72,42,24,239,210,165,50,214,184,106,58,249,154,78,46,102,132,149,4,161,112,1,73,75,217,29,20,15,138,241,246,166,168,85,133,175,138,24,105,58,145,204,44,203,96,206,177,174,21,237,242,253,125,133,13,33,163,11,12,102,0,128,246,4,141,212,73,15,120,94,47,95,58,208,147,197,90,242,128,125,36,201,145,108,15,7,40,34,148,132,122,145,156,145,156,142,148,37,89,158,14,128,108,36,171,137,27,107,202,145,156,83,118,46,90,235,71,142,186,128,52,254,68,18,67,225,3,129,3,181,46,104,176,217,169,1,175,65,57,48,45,80,250,128,130,95,216,63,156,28,91,233,35,50,74,85,131,147,181,46,18,166,50,201,223,250,17,142,85,200,48,203,94,119,58,207,186,130,211,245,93,118,146,23,142,131,114,61,163,181,249,103,221,96,244,193,252,176,242,173,98,224,88,150,200,172,163,189,6,47,29,104,107,24,193,69,107,143,245,17,134,72,142,243,85,255,133,64,17,91,238,121,158,86,150,81,128,3,161,69,110,188,183,176,166,93,183,233,203,253,254,100,108,82,23,3,140,212,247,147,187,186,151,162,239,238,255,158,161,123,239,31,67,123,149,88,123,126,0,161,181,141,72,78,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0"));
		}

		#endregion

	}

	#endregion

}

