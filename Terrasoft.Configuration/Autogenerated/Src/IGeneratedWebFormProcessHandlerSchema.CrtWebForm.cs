namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormProcessHandlerSchema(IGeneratedWebFormProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c");
			Name = "IGeneratedWebFormProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,79,61,11,194,48,16,157,45,244,63,28,116,183,187,136,139,224,199,230,32,56,167,237,75,13,52,151,114,73,133,34,254,119,147,214,66,55,111,123,199,251,100,101,225,123,85,131,238,16,81,222,233,176,61,58,214,166,29,68,5,227,56,207,222,121,182,41,4,109,4,116,229,0,209,145,190,163,235,25,140,200,65,243,64,117,114,98,111,226,106,120,127,81,220,116,144,60,139,178,178,44,105,239,7,107,149,140,135,31,142,180,151,105,224,201,44,94,164,157,80,63,171,13,183,228,52,133,39,168,22,36,119,2,7,19,70,210,226,44,117,209,60,81,122,213,98,187,4,148,171,132,126,168,58,83,175,188,255,214,220,164,125,159,169,110,1,110,230,161,9,78,191,116,95,130,94,156,69,36,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c"));
		}

		#endregion

	}

	#endregion

}

