namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordResultHandlerSchema

	/// <exclude/>
	public class IRecordResultHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordResultHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordResultHandlerSchema(IRecordResultHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b");
			Name = "IRecordResultHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,205,106,196,32,16,128,207,17,124,135,129,94,218,75,188,167,165,151,94,186,135,194,178,228,5,92,29,19,33,209,48,106,217,165,244,221,215,213,77,8,165,130,200,252,124,51,31,58,57,99,88,164,66,232,145,72,6,111,98,251,225,157,177,67,34,25,173,119,156,253,112,198,89,243,68,56,228,16,14,46,34,153,12,116,112,56,161,242,164,79,24,210,20,63,165,211,19,82,233,21,66,192,91,72,243,44,233,250,254,136,55,14,188,129,56,34,80,129,243,115,167,97,172,120,187,210,98,135,47,233,60,89,5,118,155,240,223,98,168,154,155,231,23,198,209,235,208,193,177,208,181,248,87,172,36,250,44,51,151,110,176,1,240,130,42,69,212,32,77,94,183,90,230,194,66,94,97,8,168,219,109,210,94,178,249,246,86,67,21,59,174,173,207,47,175,15,43,116,186,138,221,163,124,127,235,167,238,210,156,149,28,103,251,115,3,234,89,22,171,159,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b"));
		}

		#endregion

	}

	#endregion

}

