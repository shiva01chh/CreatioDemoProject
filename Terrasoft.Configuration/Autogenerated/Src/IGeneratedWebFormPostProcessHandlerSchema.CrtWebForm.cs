namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormPostProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormPostProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormPostProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormPostProcessHandlerSchema(IGeneratedWebFormPostProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42225206-bcb0-46e4-8cc2-2d5b3676a730");
			Name = "IGeneratedWebFormPostProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91507ba4-1e7b-4fdd-954f-ec66d764e88d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,203,78,195,48,16,60,131,196,63,172,224,2,18,52,119,30,189,20,90,122,64,84,106,17,7,196,193,216,155,98,41,182,195,218,169,168,16,255,206,58,78,90,18,160,34,183,93,207,120,103,118,28,43,12,250,82,72,132,5,18,9,239,242,48,24,57,155,235,101,69,34,104,103,225,227,96,127,175,242,218,46,97,190,246,1,205,69,175,102,120,81,160,140,88,63,152,160,69,210,114,139,25,57,194,109,85,31,139,128,234,17,95,198,142,204,28,105,165,101,4,48,228,136,112,25,7,78,109,64,202,89,210,57,76,251,132,153,243,97,70,78,162,247,183,194,170,2,169,166,102,89,6,151,190,50,70,208,122,216,212,12,91,105,133,30,12,134,87,167,32,119,4,37,211,161,76,252,168,199,229,16,94,17,36,97,156,1,104,131,14,107,200,201,25,40,248,250,8,41,197,18,7,237,136,236,219,140,178,122,41,180,4,221,170,253,143,216,223,28,117,0,113,219,124,247,102,23,119,181,118,127,14,179,122,90,58,236,187,173,27,55,239,40,171,192,118,163,161,190,207,232,221,151,40,117,174,217,102,223,218,79,111,169,83,10,18,6,44,191,144,171,195,202,35,241,187,176,41,232,195,225,130,167,196,30,200,77,115,112,153,213,140,223,47,104,134,78,85,226,182,26,56,33,94,58,203,162,221,116,118,96,174,69,16,137,29,43,80,92,166,172,102,247,243,197,25,225,91,133,62,236,190,38,37,220,138,104,242,254,67,195,202,105,213,174,245,248,161,227,31,186,235,56,133,73,165,55,123,157,170,83,136,201,142,53,22,202,71,209,79,207,208,234,111,160,173,142,147,139,38,111,180,42,69,94,215,159,233,135,232,52,235,30,127,95,103,74,2,129,178,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42225206-bcb0-46e4-8cc2-2d5b3676a730"));
		}

		#endregion

	}

	#endregion

}

