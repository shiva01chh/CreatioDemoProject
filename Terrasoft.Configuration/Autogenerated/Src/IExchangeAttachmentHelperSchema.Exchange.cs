﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IExchangeAttachmentHelperSchema

	/// <exclude/>
	public class IExchangeAttachmentHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IExchangeAttachmentHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IExchangeAttachmentHelperSchema(IExchangeAttachmentHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a10a6d20-ad3e-492b-842d-e9cb61fb4dd9");
			Name = "IExchangeAttachmentHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,77,107,219,64,16,61,55,144,255,48,56,23,7,140,117,79,28,65,236,186,169,161,134,80,55,244,80,122,88,73,35,123,65,90,137,221,85,82,17,250,223,59,210,234,211,150,84,57,180,49,62,88,51,179,111,231,189,55,187,22,8,22,162,138,153,139,240,13,165,100,42,242,245,124,21,9,159,239,19,201,52,143,196,229,197,235,229,197,135,68,113,177,135,93,170,52,134,148,15,2,116,179,164,154,63,160,64,201,221,219,170,102,203,93,25,229,48,235,95,238,129,137,61,206,191,163,179,67,249,204,93,84,243,143,76,179,186,184,185,167,68,138,83,230,74,226,158,160,97,35,52,74,159,58,187,129,77,9,117,175,53,115,15,33,10,253,25,131,24,37,149,211,215,178,44,88,168,36,12,153,76,237,226,185,92,1,172,90,162,224,144,47,2,94,34,207,171,98,10,8,22,128,135,49,10,15,133,155,194,139,100,84,91,86,44,172,6,126,156,56,1,119,107,152,193,254,94,115,82,21,171,45,234,67,228,169,27,120,204,65,76,242,152,64,30,88,73,100,26,21,37,16,193,149,232,223,77,42,69,203,31,133,172,19,203,166,110,148,102,194,112,58,109,217,68,98,38,89,8,153,229,119,147,68,161,36,163,133,49,114,98,55,182,121,106,167,154,224,11,43,199,232,135,92,135,140,7,247,158,39,81,169,137,189,203,212,148,128,89,16,152,137,158,98,72,212,137,20,202,62,151,233,194,42,87,102,80,71,149,133,126,71,209,105,155,27,180,85,152,129,210,50,155,203,99,38,215,183,67,70,177,32,80,224,112,225,65,104,220,5,63,146,221,190,101,152,91,2,100,251,156,202,11,215,135,66,67,42,44,100,228,116,198,54,30,165,199,90,169,10,109,222,32,224,128,155,69,27,157,160,155,178,197,145,88,177,140,232,52,104,142,170,27,239,209,228,211,29,234,97,208,210,240,101,148,144,220,99,36,238,155,150,70,25,236,152,143,75,242,47,163,53,61,158,163,66,221,25,24,210,96,116,153,65,163,103,168,249,13,78,202,87,211,192,137,227,97,221,110,243,186,114,171,123,118,236,36,148,64,221,147,208,175,76,223,129,60,187,207,182,200,155,181,72,66,148,204,9,112,81,95,141,54,60,160,54,167,171,6,153,182,12,41,54,250,63,98,130,207,3,186,185,209,3,39,61,89,93,47,57,235,8,254,35,225,155,144,173,78,236,90,42,224,94,191,99,159,74,106,239,104,221,50,221,120,157,246,85,215,105,147,202,136,171,180,75,67,34,214,248,119,157,127,137,152,55,189,206,216,152,43,119,172,79,117,39,221,86,181,183,233,53,235,57,226,30,100,61,212,181,211,246,210,6,231,55,77,49,107,53,225,70,244,174,65,180,223,151,229,224,93,208,221,96,123,136,156,84,227,143,159,217,204,212,187,173,76,229,223,229,186,162,119,7,243,210,148,63,255,54,47,135,173,32,197,232,243,7,252,80,97,173,196,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a10a6d20-ad3e-492b-842d-e9cb61fb4dd9"));
		}

		#endregion

	}

	#endregion

}
