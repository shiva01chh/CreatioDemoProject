﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientValidatorSchema

	/// <exclude/>
	public class BulkEmailRecipientValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientValidatorSchema(BulkEmailRecipientValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88b97f9d-7957-455a-8316-f5457c4023f6");
			Name = "BulkEmailRecipientValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,193,110,219,48,12,61,167,64,255,129,200,46,233,197,190,47,137,15,41,186,34,64,11,12,221,176,107,193,216,116,34,76,150,92,73,206,144,21,251,247,81,146,237,56,105,234,21,243,193,176,40,146,122,124,239,201,10,43,178,53,230,4,223,201,24,180,186,116,201,173,86,165,216,54,6,157,208,234,250,234,245,250,106,210,88,161,182,240,237,96,29,85,188,47,37,229,126,211,38,247,164,200,136,124,126,158,243,32,212,11,7,57,252,201,208,150,83,225,86,162,181,159,97,213,200,159,119,21,10,249,68,185,168,5,41,247,3,165,40,208,105,19,210,211,52,133,133,109,170,10,205,33,107,215,109,6,89,48,93,17,84,152,27,109,161,52,186,2,75,170,32,3,138,103,1,84,69,183,38,127,76,210,245,76,7,77,235,102,35,69,14,185,135,52,142,104,242,26,80,245,83,124,17,36,11,30,227,171,17,123,70,20,55,235,184,128,7,97,221,98,133,150,218,6,92,240,212,72,202,224,121,127,18,176,243,97,149,33,44,180,146,135,49,32,171,70,72,63,210,243,38,126,204,91,84,60,104,4,118,138,146,21,180,206,52,57,87,122,172,97,218,152,113,78,111,8,172,149,112,130,143,250,205,12,35,40,250,5,130,235,81,177,43,116,9,110,71,92,66,4,185,161,114,57,29,65,57,77,179,200,105,210,31,149,158,159,181,168,209,96,21,180,90,78,219,105,166,89,48,7,148,218,64,8,121,35,29,41,3,227,57,75,22,105,40,13,157,90,1,71,176,204,62,192,102,123,252,13,120,139,79,38,231,42,193,50,112,241,158,170,179,155,121,44,107,219,112,250,81,29,142,123,86,67,159,54,241,207,184,102,143,228,118,58,90,75,59,190,94,84,124,68,177,72,16,171,244,134,174,203,18,212,93,115,216,107,81,192,0,227,251,36,116,3,38,255,61,209,191,12,120,188,224,40,229,241,146,199,229,230,16,163,35,83,189,49,214,177,197,52,235,245,247,52,109,216,21,237,143,225,130,159,2,39,29,152,217,250,78,53,21,25,220,72,90,172,31,201,90,220,82,223,108,173,74,157,13,160,118,252,177,135,9,243,29,204,246,104,6,191,43,161,46,228,158,38,239,59,123,250,228,115,25,250,146,73,159,150,244,64,251,206,173,35,189,48,221,251,178,70,49,58,12,114,196,63,127,1,43,188,122,149,16,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88b97f9d-7957-455a-8316-f5457c4023f6"));
		}

		#endregion

	}

	#endregion

}

