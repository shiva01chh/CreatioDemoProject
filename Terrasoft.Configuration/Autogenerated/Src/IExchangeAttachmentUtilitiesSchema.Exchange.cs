﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IExchangeAttachmentUtilitiesSchema

	/// <exclude/>
	public class IExchangeAttachmentUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IExchangeAttachmentUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IExchangeAttachmentUtilitiesSchema(IExchangeAttachmentUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3576a96a-4ac9-410d-8496-243912c0348d");
			Name = "IExchangeAttachmentUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,93,107,219,48,20,125,94,161,255,225,146,190,164,16,236,247,54,53,52,89,86,2,11,148,101,165,15,99,15,138,124,157,8,108,57,72,114,59,175,236,191,79,182,252,33,229,195,115,58,90,24,172,244,161,190,146,206,189,231,156,235,43,23,56,73,80,110,9,69,248,138,66,16,153,70,202,155,166,60,98,235,76,16,197,82,126,126,246,114,126,246,33,147,140,175,97,153,75,133,137,94,143,99,164,197,162,244,238,144,163,96,244,186,217,179,96,84,164,37,204,236,7,221,16,190,70,239,17,87,75,20,79,140,162,244,62,18,69,218,205,118,78,129,58,174,87,46,4,174,53,52,204,185,66,17,233,202,174,96,94,67,221,42,69,232,38,65,174,30,20,139,153,98,40,245,9,253,235,251,62,140,101,150,36,68,228,65,245,92,31,2,210,156,146,144,213,231,128,213,248,94,179,95,7,56,137,33,196,45,242,16,57,205,225,89,144,45,138,122,199,216,183,82,108,179,85,204,104,11,243,167,42,95,74,118,13,189,5,170,77,26,202,43,184,47,113,204,226,46,141,50,48,21,72,148,46,120,44,17,129,10,140,110,6,141,180,245,31,149,190,3,63,208,5,73,69,184,161,181,95,181,137,108,137,32,9,20,222,223,12,50,137,66,59,206,141,163,131,192,74,243,224,46,217,224,99,191,196,56,14,57,75,8,139,111,195,80,160,148,131,96,89,8,42,0,139,32,16,19,221,199,16,168,50,193,101,112,42,211,177,95,159,44,160,118,118,86,250,237,68,135,46,55,112,85,24,129,84,162,104,208,93,38,151,215,93,70,145,56,150,176,98,60,132,196,184,11,81,42,28,223,10,168,133,198,33,235,146,193,51,83,155,74,58,189,94,169,199,244,59,54,15,245,114,95,7,101,37,201,33,221,14,203,213,225,93,149,221,198,154,215,5,245,132,216,138,84,191,52,69,219,59,48,247,38,156,47,81,117,99,213,102,78,210,76,75,217,33,223,177,6,176,182,193,146,68,56,209,150,20,36,134,187,173,81,41,55,2,67,17,12,249,17,88,165,66,203,230,191,249,239,96,126,207,209,228,222,28,222,107,39,149,44,231,82,233,140,30,82,57,167,27,145,114,246,179,188,249,204,180,250,119,218,115,4,253,102,154,197,185,179,163,191,152,154,247,90,52,105,25,218,55,43,109,190,10,250,182,110,13,20,244,211,240,216,101,113,114,121,174,29,243,25,207,18,20,100,21,227,184,189,185,3,184,67,213,62,202,161,227,90,149,227,109,228,131,136,197,250,155,2,67,88,229,123,167,219,35,39,77,137,191,147,218,70,114,10,8,90,133,128,133,199,61,250,84,51,122,31,179,38,249,60,60,104,88,243,14,216,44,122,140,117,75,181,54,141,247,57,37,225,240,178,168,221,76,252,190,102,180,201,29,63,90,228,163,110,60,165,44,132,50,173,37,124,11,247,170,126,36,78,90,154,234,239,89,205,237,205,169,116,190,195,135,107,114,91,97,149,43,252,246,189,112,126,106,214,187,53,185,208,83,207,124,122,151,207,191,204,255,26,78,80,199,138,159,223,123,214,207,0,20,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3576a96a-4ac9-410d-8496-243912c0348d"));
		}

		#endregion

	}

	#endregion

}

