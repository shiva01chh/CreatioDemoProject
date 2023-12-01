﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeAttachmentHelperSchema

	/// <exclude/>
	public class ExchangeAttachmentHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeAttachmentHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeAttachmentHelperSchema(ExchangeAttachmentHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e73aca0-5a61-43b4-ab70-33fd58ff86f9");
			Name = "ExchangeAttachmentHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,77,111,155,64,16,61,59,82,254,195,212,185,96,201,194,61,39,177,165,124,151,42,110,35,185,81,14,81,14,107,24,236,149,96,161,187,139,91,84,229,191,103,22,12,44,196,137,80,235,30,90,14,198,204,206,188,249,120,111,23,64,176,24,85,202,124,132,111,40,37,83,73,168,221,139,68,132,124,149,73,166,121,34,14,15,126,29,30,12,50,197,197,10,22,185,210,24,211,122,20,161,111,22,149,123,131,2,37,247,79,186,62,183,92,124,111,140,115,238,203,164,192,190,250,233,175,153,88,161,251,128,203,5,202,13,247,81,185,151,76,179,198,217,46,68,34,217,129,174,93,75,238,53,243,117,34,57,42,114,162,240,35,137,43,42,10,46,34,166,212,49,84,169,206,180,102,254,58,70,161,63,97,148,162,44,124,39,147,9,156,170,44,142,153,204,103,245,51,34,248,18,195,233,208,123,29,124,175,121,196,53,37,27,78,102,192,227,52,66,99,45,102,228,86,0,19,11,241,241,18,67,150,69,250,156,139,128,106,119,116,158,98,18,58,239,33,143,198,240,133,248,128,41,12,63,39,203,123,133,146,168,16,229,168,135,163,167,63,6,221,63,226,153,33,96,23,108,154,45,35,238,131,111,168,120,147,9,56,134,115,166,240,109,162,6,70,123,53,175,115,212,235,36,32,102,239,74,240,130,200,87,76,246,160,178,132,119,47,36,50,93,103,223,170,145,216,173,65,108,58,171,142,146,13,105,144,7,8,157,56,216,137,230,180,103,67,50,182,31,199,160,180,52,186,54,230,171,152,241,232,44,8,36,42,53,130,162,241,129,68,157,73,1,2,127,212,233,74,22,114,143,4,232,140,118,183,224,116,179,188,130,55,155,109,240,252,219,243,171,149,224,46,88,136,70,57,30,237,249,254,147,51,165,204,169,14,182,66,176,17,156,238,76,85,121,31,131,89,245,2,224,197,109,12,119,50,33,2,117,190,64,13,105,249,223,232,178,239,212,236,156,167,118,53,51,167,206,88,165,178,224,255,207,169,141,161,159,70,21,138,96,43,163,127,102,208,55,168,27,179,234,61,106,239,74,100,49,74,182,140,240,180,137,159,65,27,206,105,49,18,151,247,206,104,182,86,215,10,251,75,205,157,231,94,176,231,6,13,228,206,38,107,77,176,218,217,11,58,157,119,102,85,141,199,125,88,163,68,135,94,30,51,64,151,196,57,157,182,81,246,54,158,219,132,245,31,200,38,225,1,152,8,167,129,178,234,170,122,107,44,5,188,179,87,165,210,158,211,100,235,93,243,50,215,248,248,4,77,228,251,181,111,152,132,144,71,86,118,176,71,15,76,193,117,107,185,232,109,192,67,112,58,97,31,166,32,178,168,62,5,42,198,219,94,238,182,168,18,101,80,252,62,215,133,152,77,255,78,33,94,107,185,41,164,19,214,45,196,32,167,214,33,55,45,142,38,235,216,115,204,231,134,245,76,2,252,42,162,124,180,45,210,138,117,233,85,233,152,50,22,254,26,99,102,111,224,30,222,115,30,227,182,255,202,187,93,122,41,31,11,161,114,51,45,196,77,52,181,208,9,52,89,108,252,147,22,7,86,168,69,128,53,124,235,200,46,244,243,241,201,150,240,17,157,241,229,199,22,61,149,54,219,84,88,232,122,1,245,206,62,69,54,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e73aca0-5a61-43b4-ab70-33fd58ff86f9"));
		}

		#endregion

	}

	#endregion

}

