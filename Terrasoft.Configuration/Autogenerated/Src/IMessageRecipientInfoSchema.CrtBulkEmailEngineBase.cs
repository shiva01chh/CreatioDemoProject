namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMessageRecipientInfoSchema

	/// <exclude/>
	public class IMessageRecipientInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMessageRecipientInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMessageRecipientInfoSchema(IMessageRecipientInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e93974ca-bdd6-46d5-a877-c7093a88aaec");
			Name = "IMessageRecipientInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("956f026d-fde0-4edb-a4cc-83d98fd529ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,193,110,219,48,12,61,167,64,255,129,64,15,219,128,193,185,183,69,135,33,41,2,31,10,4,94,247,1,154,69,59,196,108,201,147,228,117,69,208,127,31,37,57,158,231,196,94,214,97,190,88,162,40,190,71,82,143,74,212,104,27,145,35,60,162,49,194,234,194,37,43,173,10,42,91,35,28,105,5,151,23,251,203,139,69,107,73,149,240,233,217,58,172,111,70,123,190,80,85,152,123,111,155,108,80,161,161,156,125,216,235,202,96,233,99,164,202,161,41,24,229,26,210,7,180,86,148,152,97,78,13,161,114,169,42,116,112,94,46,151,112,107,219,186,22,230,249,174,219,111,141,254,78,18,45,212,232,118,90,90,16,74,66,99,116,131,198,17,155,11,109,224,73,155,175,240,68,110,7,230,16,19,116,1,181,160,138,57,38,135,200,203,65,232,166,253,82,81,14,116,160,53,197,106,177,15,204,250,60,182,61,242,53,108,67,140,120,62,166,30,12,159,21,125,107,17,152,190,114,84,16,26,207,170,167,152,244,247,134,196,22,155,150,36,164,18,246,224,119,139,18,221,77,88,88,94,4,211,203,12,98,207,254,141,5,244,249,131,144,210,112,102,19,96,214,25,223,197,123,239,250,49,122,190,14,152,95,140,19,185,135,229,108,187,100,223,118,198,36,75,229,187,9,2,220,128,195,221,236,181,73,207,98,79,67,135,66,119,110,30,250,24,249,79,192,107,44,68,91,57,200,181,68,223,90,183,67,110,175,109,88,5,24,30,102,52,204,247,219,87,32,85,228,72,84,89,119,119,229,227,205,243,185,66,37,227,147,12,251,104,29,25,79,105,239,254,71,67,81,214,231,169,110,160,52,167,129,217,0,246,17,88,61,156,100,29,215,62,221,58,74,232,76,193,141,169,252,147,212,58,245,14,217,73,225,112,162,230,107,62,122,164,26,63,192,47,18,222,246,159,138,190,94,253,229,172,27,205,183,90,228,70,243,43,227,144,202,157,87,220,35,200,67,117,79,86,111,131,206,2,3,89,255,247,143,246,55,196,169,34,82,24,248,188,189,141,99,228,61,196,255,29,60,248,235,126,146,248,74,66,16,241,156,142,142,224,13,54,156,143,24,76,206,57,13,103,209,59,140,143,49,224,11,156,104,82,56,26,126,63,1,70,67,126,64,4,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e93974ca-bdd6-46d5-a877-c7093a88aaec"));
		}

		#endregion

	}

	#endregion

}

