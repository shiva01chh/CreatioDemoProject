﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangePhoneNumbersDetailsSynchronizerSchema

	/// <exclude/>
	public class ExchangePhoneNumbersDetailsSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangePhoneNumbersDetailsSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangePhoneNumbersDetailsSynchronizerSchema(ExchangePhoneNumbersDetailsSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b0d376d-8b5d-4e94-96ce-119e8e673e13");
			Name = "ExchangePhoneNumbersDetailsSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,86,193,110,219,56,16,61,171,64,255,97,170,189,56,128,33,3,61,102,109,31,214,9,210,96,147,52,136,187,219,195,98,15,180,52,142,137,74,164,150,164,220,170,65,254,125,135,164,40,201,142,237,218,233,2,235,139,109,106,230,205,123,143,228,140,64,176,2,117,201,82,132,79,168,20,211,114,105,146,121,45,210,228,242,91,186,98,226,17,223,190,121,122,251,38,170,52,23,143,48,175,181,193,226,215,173,255,201,76,230,57,166,134,75,161,147,43,20,168,120,250,34,230,134,139,127,186,197,174,214,76,138,37,127,172,20,179,233,187,3,20,238,91,79,46,133,225,134,163,222,21,96,85,116,235,65,14,76,224,150,167,74,186,144,176,152,124,198,197,28,213,154,167,168,147,11,102,24,229,81,230,47,10,31,137,21,204,114,166,245,121,11,113,191,146,2,239,170,98,129,74,95,160,97,60,215,182,214,74,73,193,191,163,114,169,163,209,8,198,186,42,10,166,234,105,243,255,94,201,53,207,80,67,129,102,37,51,13,75,169,128,244,27,150,26,40,45,40,8,143,10,186,197,115,190,192,87,110,86,109,253,36,224,143,122,5,184,48,168,4,203,33,181,100,143,229,10,231,148,26,69,33,218,71,244,3,198,109,209,30,210,239,88,15,97,215,3,218,14,213,127,212,136,179,252,158,156,45,157,165,116,86,140,170,82,35,21,57,123,95,45,114,158,250,136,109,231,220,194,76,33,51,228,156,23,199,41,151,9,58,178,214,192,244,117,6,190,116,208,175,148,76,177,2,236,173,152,196,22,26,191,153,120,58,223,66,107,30,36,227,145,11,223,157,157,203,148,229,215,116,246,227,233,141,253,9,154,196,50,58,129,219,220,48,199,2,197,15,208,20,22,210,160,135,123,112,191,79,194,43,157,195,199,30,139,129,253,51,243,34,131,216,33,220,4,65,208,74,27,186,227,211,59,65,97,203,161,227,123,230,98,206,97,193,52,14,90,176,14,2,226,153,44,138,74,240,212,209,255,84,151,120,157,197,195,30,130,11,113,176,27,145,241,25,60,57,108,175,192,70,106,186,222,93,94,255,104,186,22,17,69,22,93,223,178,146,226,4,126,133,11,238,218,22,157,128,253,7,253,170,226,217,180,169,20,53,95,209,158,232,228,55,219,109,80,107,183,28,220,177,149,44,202,224,133,80,119,13,116,242,89,170,47,46,227,58,243,110,69,207,195,227,234,125,144,5,158,86,171,205,56,185,214,173,92,240,252,196,106,189,156,147,235,109,120,249,254,103,204,116,95,207,238,4,60,55,125,8,69,230,91,209,102,95,186,245,173,249,220,54,107,67,51,13,179,3,93,233,1,77,165,132,6,12,179,165,223,131,96,205,242,10,129,47,65,151,152,242,37,221,62,127,161,21,46,155,59,109,136,52,9,141,71,211,99,59,82,200,152,142,53,34,164,4,53,137,247,216,71,168,109,163,124,217,90,148,167,222,46,92,238,151,208,227,182,157,69,48,196,245,75,31,166,153,66,25,150,228,48,138,180,222,72,239,162,203,224,47,172,185,50,149,107,143,202,14,234,43,52,61,33,131,61,234,160,113,34,180,128,53,83,13,245,73,171,229,15,195,115,110,234,100,206,150,72,168,127,90,49,175,153,103,161,199,69,158,225,116,208,235,55,195,150,136,239,47,222,33,79,165,127,222,58,185,114,77,111,40,244,26,0,11,41,115,63,254,105,155,28,185,215,136,221,178,107,39,155,119,158,120,114,173,239,170,60,255,168,46,139,210,212,3,135,112,246,3,146,107,201,51,152,163,105,123,127,67,212,190,119,213,180,203,193,136,221,254,253,12,119,186,56,131,3,188,3,94,163,209,231,248,139,222,177,74,136,57,189,156,86,133,240,180,99,95,137,134,75,79,252,129,248,110,163,125,127,177,79,238,232,34,14,33,204,145,191,26,210,127,31,107,228,67,59,157,254,11,39,253,172,11,51,119,2,29,122,103,226,86,12,13,62,50,243,128,125,27,241,27,35,180,21,75,149,122,166,209,54,90,59,178,158,115,227,112,85,130,227,71,217,115,65,111,46,6,189,6,111,253,41,55,226,255,243,194,130,28,24,46,126,181,191,232,86,232,243,47,235,187,91,35,126,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b0d376d-8b5d-4e94-96ce-119e8e673e13"));
		}

		#endregion

	}

	#endregion

}
