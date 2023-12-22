﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeAddressDetailsSynchronizerSchema

	/// <exclude/>
	public class ExchangeAddressDetailsSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeAddressDetailsSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeAddressDetailsSynchronizerSchema(ExchangeAddressDetailsSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1cedbf6d-ff32-4d37-a6f0-83039a008d95");
			Name = "ExchangeAddressDetailsSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,221,111,219,54,16,127,118,129,254,15,172,247,226,96,134,178,231,38,54,144,58,69,27,44,109,131,56,221,128,21,125,96,228,115,66,76,18,85,146,114,235,5,249,223,119,252,166,100,249,107,216,128,229,33,150,200,187,227,125,252,238,126,20,169,104,9,178,166,57,144,59,16,130,74,190,84,217,124,93,229,217,219,31,249,35,173,30,224,229,139,167,151,47,6,141,100,213,3,153,175,165,130,242,172,243,158,205,120,81,64,174,24,175,100,246,14,42,16,44,223,144,185,102,213,183,141,197,59,248,161,226,98,116,96,198,171,37,123,104,4,213,54,251,5,4,108,91,207,222,86,138,41,6,178,79,64,135,22,215,125,140,100,66,62,176,92,112,35,226,23,179,223,225,126,14,98,197,114,144,217,37,85,20,245,80,243,39,1,15,232,21,153,21,84,202,215,193,196,197,98,33,64,202,75,80,148,21,82,31,243,40,120,197,254,2,97,180,78,79,79,201,185,108,202,146,138,245,212,189,223,8,190,98,11,144,164,4,245,200,23,146,44,185,32,24,186,162,185,34,212,218,35,50,88,50,201,32,223,153,122,12,135,102,222,242,105,98,186,110,238,11,150,147,92,251,119,128,123,228,53,234,12,6,94,208,74,164,2,231,225,180,155,199,181,100,57,45,156,177,95,97,61,38,219,54,177,8,34,221,118,113,105,7,159,76,70,98,34,17,54,74,52,185,226,2,243,121,99,188,183,18,221,164,153,133,153,0,170,48,105,54,62,134,186,180,66,244,234,220,229,199,230,110,51,121,118,165,166,130,150,68,183,198,100,168,141,34,76,135,211,121,199,154,219,200,206,79,141,120,191,118,193,49,37,87,136,245,225,244,90,63,18,137,97,82,68,92,215,55,40,160,132,106,143,53,1,37,87,96,205,221,154,231,163,236,57,100,236,199,196,72,191,204,108,124,62,206,49,185,246,177,144,16,213,216,96,39,129,143,175,51,137,174,158,24,153,215,228,158,74,24,5,99,209,4,25,58,71,238,214,53,92,45,134,227,68,23,55,157,65,39,51,60,33,79,198,30,91,146,81,148,35,175,38,164,106,138,194,239,14,108,80,122,75,98,115,71,193,46,76,237,148,24,12,158,205,127,237,129,252,64,107,84,73,124,210,43,70,234,217,1,23,170,133,197,110,27,200,216,207,53,8,61,121,14,128,241,185,4,32,185,128,229,100,248,174,97,139,225,233,148,172,104,209,32,176,249,146,40,60,53,160,120,41,120,153,138,239,104,71,109,5,170,166,4,59,57,183,64,220,193,0,27,71,225,207,37,51,147,27,55,119,55,186,246,114,218,77,11,153,56,0,84,240,253,72,75,79,30,58,225,97,176,67,43,123,207,75,136,227,196,204,12,105,22,91,224,241,166,158,199,199,89,127,163,249,0,159,55,78,240,27,253,167,184,135,103,203,12,219,145,241,193,14,120,132,133,96,43,156,94,118,183,182,47,100,197,217,130,92,212,53,42,223,113,119,208,92,9,36,168,145,253,121,211,176,98,129,147,218,33,98,140,165,211,203,22,48,105,67,216,245,236,74,126,196,94,248,36,222,150,181,90,143,172,84,232,12,1,170,17,85,138,122,173,233,76,103,215,80,61,224,144,156,146,95,130,130,223,178,30,142,176,63,135,228,103,119,182,51,131,211,70,194,22,249,150,160,13,124,79,31,37,217,194,174,205,21,44,124,190,220,43,225,43,36,116,164,78,114,207,121,97,41,19,137,224,55,125,210,104,71,153,77,95,225,175,15,109,39,119,133,254,155,4,76,124,86,172,96,106,157,205,233,18,222,129,50,231,237,132,186,195,199,161,28,217,183,61,29,37,163,108,28,34,56,235,86,142,76,58,19,208,214,153,44,41,150,38,173,182,91,127,213,139,21,95,187,25,134,137,69,14,175,188,209,190,124,18,183,182,66,113,103,174,52,130,211,119,1,160,78,210,113,217,83,54,131,248,57,168,192,40,174,116,250,226,182,38,139,16,240,246,220,244,84,115,69,133,101,21,45,130,85,139,102,8,149,164,77,35,49,125,137,70,111,2,211,212,233,19,220,29,195,221,221,244,57,142,39,51,75,200,97,131,202,116,150,104,29,77,170,126,251,170,172,139,232,196,134,209,189,174,236,134,46,36,12,255,127,199,111,219,215,189,129,39,36,99,17,60,246,156,100,207,153,122,40,130,188,230,252,207,166,182,116,222,77,241,73,118,177,33,182,209,83,45,19,7,161,35,206,12,77,136,173,233,61,114,49,247,15,250,48,218,211,116,180,186,105,16,144,154,253,193,116,72,45,201,27,142,116,94,204,248,2,186,194,45,230,66,53,79,221,95,92,41,190,198,176,95,109,198,157,93,84,235,81,36,143,13,179,104,208,183,254,29,119,177,56,127,123,82,228,120,43,71,16,126,196,11,109,55,8,61,117,206,82,65,75,8,125,162,102,238,180,100,115,59,163,122,237,182,199,87,75,141,198,121,50,233,54,108,11,88,239,161,192,219,29,126,223,170,207,21,251,214,232,212,181,176,235,203,155,234,144,146,214,102,0,233,105,180,164,77,161,70,173,253,205,49,158,166,30,79,144,153,39,183,81,116,52,150,35,154,223,84,255,18,21,190,118,217,222,233,153,132,35,40,240,242,172,239,100,153,225,128,158,90,59,177,9,105,235,245,145,127,84,194,241,62,227,69,83,86,118,182,15,173,14,222,30,76,27,57,136,236,105,6,15,148,147,109,1,216,130,30,16,66,16,140,65,248,165,227,194,240,90,199,5,18,129,188,53,20,7,210,67,202,17,36,147,138,248,181,35,139,226,213,142,172,75,236,181,86,60,71,140,135,253,151,131,219,240,209,246,111,221,14,236,103,160,255,66,157,144,120,66,236,195,142,204,65,83,63,132,109,35,62,242,226,177,253,242,214,61,199,250,22,15,210,28,179,251,34,224,204,153,235,220,164,229,167,233,97,93,64,71,242,221,43,94,87,58,86,220,41,216,155,95,71,236,54,224,220,73,69,94,234,138,34,137,5,75,154,229,186,251,238,215,166,224,204,93,93,147,218,108,126,201,7,70,35,54,155,71,43,181,242,123,8,74,47,161,0,5,22,70,118,162,31,243,249,241,95,65,242,159,164,169,255,147,204,174,166,139,184,146,254,253,13,190,160,173,80,63,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1cedbf6d-ff32-4d37-a6f0-83039a008d95"));
		}

		#endregion

	}

	#endregion

}

