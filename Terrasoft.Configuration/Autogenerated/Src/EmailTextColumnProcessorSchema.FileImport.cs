namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTextColumnProcessorSchema

	/// <exclude/>
	public class EmailTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTextColumnProcessorSchema(EmailTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d219b6-f9e4-471d-9053-15d73a72c898");
			Name = "EmailTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,209,107,219,48,16,198,159,83,232,255,112,100,47,9,12,251,61,77,2,109,186,142,192,24,133,37,123,25,123,80,228,115,122,96,75,222,73,42,11,101,255,251,78,114,156,213,89,92,168,95,44,29,159,190,79,247,147,100,84,141,174,81,26,97,131,204,202,217,210,103,43,107,74,218,7,86,158,172,201,30,168,194,117,221,88,246,215,87,47,215,87,163,224,200,236,225,219,193,121,172,111,78,243,215,171,25,135,234,217,131,210,222,50,161,19,133,104,62,48,238,37,3,86,149,114,110,6,159,106,69,213,6,127,251,149,173,66,109,30,217,106,116,206,114,210,230,121,14,115,50,79,200,228,11,171,65,51,150,139,241,5,245,56,95,118,114,23,234,90,241,161,155,223,26,32,227,188,50,210,174,45,193,63,145,3,29,163,65,6,44,28,172,113,180,171,16,74,203,208,180,126,177,137,47,214,236,99,16,232,148,4,207,170,10,232,178,46,37,127,21,243,227,30,75,21,42,127,71,166,144,165,19,127,104,208,150,147,245,217,30,167,31,225,171,144,135,5,24,249,137,96,168,245,233,244,167,184,54,97,87,145,62,238,117,72,10,51,184,200,110,244,146,248,253,131,45,93,122,14,241,32,132,249,99,178,110,21,239,68,252,31,227,84,88,49,42,143,174,79,90,40,136,18,241,104,57,212,130,248,102,39,227,252,220,121,222,40,86,117,34,182,24,7,135,44,157,24,212,241,150,142,151,91,153,203,249,116,133,108,158,39,117,90,124,196,55,148,58,217,246,188,160,111,61,21,174,59,229,112,114,94,142,143,97,244,231,200,22,77,209,226,237,179,150,140,6,217,203,133,159,197,177,151,181,88,188,5,251,78,146,222,1,251,94,121,213,94,199,150,113,48,244,75,198,84,160,241,84,18,242,0,206,166,219,11,216,103,121,161,162,135,207,129,138,228,247,61,218,109,196,109,187,46,96,177,236,215,178,19,196,115,233,205,69,18,45,159,126,49,213,226,247,23,27,76,52,83,125,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d219b6-f9e4-471d-9053-15d73a72c898"));
		}

		#endregion

	}

	#endregion

}

