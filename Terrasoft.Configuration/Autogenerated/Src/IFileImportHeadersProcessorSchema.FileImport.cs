namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportHeadersProcessorSchema

	/// <exclude/>
	public class IFileImportHeadersProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportHeadersProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportHeadersProcessorSchema(IFileImportHeadersProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f");
			Name = "IFileImportHeadersProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,75,106,195,48,16,93,39,144,59,12,222,180,133,98,29,160,142,55,38,109,179,78,233,94,81,70,137,64,31,51,35,21,66,233,221,43,203,73,108,104,99,4,70,210,155,247,147,151,14,185,151,10,225,3,137,36,7,29,235,46,120,109,142,137,100,52,193,215,175,198,226,214,245,129,34,124,175,150,139,196,198,31,97,119,230,136,46,35,173,69,53,192,184,126,67,143,100,212,203,13,51,39,36,172,55,62,154,104,144,7,64,94,125,218,91,163,192,248,136,164,7,253,237,36,244,142,242,128,196,29,161,140,129,138,236,2,132,16,208,112,114,78,210,185,189,157,20,12,50,152,209,161,10,54,57,207,160,243,88,79,65,33,51,30,224,84,248,30,24,190,164,77,200,245,196,39,254,16,54,189,36,233,192,231,94,214,21,133,16,119,234,132,78,86,109,195,136,160,8,245,186,42,81,206,151,11,209,114,72,148,3,112,217,23,105,85,92,93,221,212,141,40,164,119,68,70,212,103,177,86,181,227,31,52,5,7,58,55,242,207,48,97,76,228,185,157,218,135,160,97,230,111,108,177,43,188,217,95,35,174,19,3,199,118,227,147,67,146,123,139,205,28,216,94,186,28,203,31,207,248,113,30,21,166,58,158,7,166,187,84,37,67,11,243,96,79,195,179,255,172,150,121,173,150,243,239,23,140,241,215,240,129,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f"));
		}

		#endregion

	}

	#endregion

}

