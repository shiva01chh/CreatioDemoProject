namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesProcessorErrorEventArgsSchema

	/// <exclude/>
	public class LookupValuesProcessorErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesProcessorErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesProcessorErrorEventArgsSchema(LookupValuesProcessorErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f");
			Name = "LookupValuesProcessorErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,77,106,195,48,16,133,215,14,228,14,3,217,180,16,114,128,132,46,74,112,75,160,45,129,180,221,171,242,196,21,181,37,51,35,149,134,144,187,87,146,127,98,135,54,216,11,163,25,205,123,111,244,105,81,34,87,66,34,188,34,145,96,179,183,139,181,209,123,149,59,18,86,25,189,120,80,5,110,202,202,144,157,78,142,211,73,226,88,233,28,118,7,182,88,174,166,19,223,153,17,230,126,18,96,93,8,230,37,60,25,243,229,170,119,81,56,228,45,25,137,204,134,82,34,255,251,70,109,239,41,231,168,171,220,71,161,36,200,160,26,35,130,37,244,12,146,176,76,151,237,119,102,75,78,90,67,126,131,109,116,142,33,109,202,8,255,155,71,167,50,240,133,178,135,157,252,196,82,188,109,178,57,120,223,240,98,105,10,87,234,23,207,171,107,149,138,3,140,104,58,135,244,71,98,21,144,133,212,36,193,182,188,133,184,105,146,14,141,225,238,50,106,21,199,214,93,142,159,56,135,214,151,207,189,68,127,221,95,160,30,232,150,8,246,237,57,94,157,106,28,51,212,89,205,172,169,27,128,158,73,133,100,21,254,141,239,236,123,62,29,33,71,187,2,165,45,146,22,5,112,168,78,3,89,36,122,249,240,255,116,157,170,193,59,120,236,136,176,70,214,3,120,77,212,7,209,192,233,183,98,39,124,191,99,18,174,147,34,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f"));
		}

		#endregion

	}

	#endregion

}

