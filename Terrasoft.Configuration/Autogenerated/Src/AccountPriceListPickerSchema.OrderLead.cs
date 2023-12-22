﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountPriceListPickerSchema

	/// <exclude/>
	public class AccountPriceListPickerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountPriceListPickerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountPriceListPickerSchema(AccountPriceListPickerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7a0a820-d8a1-46e7-b253-7496058e4918");
			Name = "AccountPriceListPicker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,111,211,64,16,62,187,82,255,195,200,189,56,18,178,239,37,177,68,31,169,34,129,84,209,82,14,136,195,178,30,55,43,236,221,176,143,66,64,252,119,198,187,107,39,118,147,162,250,54,179,243,248,190,111,102,44,89,139,102,195,56,194,61,106,205,140,170,109,126,169,100,45,30,157,102,86,40,121,122,242,231,244,36,113,70,200,71,184,219,26,139,237,219,193,222,79,105,91,37,15,191,104,60,230,207,175,46,142,62,45,25,183,74,11,52,20,65,49,103,26,31,9,13,92,54,204,152,115,120,199,185,114,210,222,106,193,241,189,48,246,86,240,239,168,125,100,81,20,48,55,174,109,153,222,150,209,246,89,80,43,13,6,27,228,29,47,24,114,161,214,170,237,43,230,125,133,98,175,196,151,43,172,153,107,236,133,144,21,65,205,236,118,131,170,206,86,147,246,179,217,87,10,222,184,111,141,224,192,125,203,195,56,225,28,166,185,148,216,233,60,240,92,10,108,42,34,122,171,149,37,192,88,121,110,201,166,55,65,35,171,148,108,182,240,201,160,166,137,201,72,107,108,6,241,146,51,148,85,40,28,237,94,77,37,141,213,174,83,186,235,229,145,135,136,169,138,222,177,146,194,10,214,136,223,104,128,129,196,159,32,40,159,73,218,30,85,131,93,35,165,32,2,215,88,47,210,195,212,211,162,12,210,228,67,151,98,218,102,190,97,154,181,32,105,53,23,169,27,241,73,203,123,234,210,249,128,15,206,124,94,248,12,95,32,202,127,184,123,54,17,107,92,124,6,126,4,201,36,104,49,9,235,86,54,249,251,178,176,31,208,174,85,152,159,120,98,22,251,233,121,3,238,252,18,194,13,218,41,204,240,146,221,56,81,1,11,111,171,170,199,165,209,58,45,189,238,49,110,140,116,230,163,146,132,14,168,113,173,204,210,161,236,170,74,135,199,37,109,123,214,79,103,231,254,188,70,141,89,218,69,230,43,115,253,195,177,38,11,117,114,191,37,217,14,78,204,97,38,194,120,165,32,71,22,218,115,38,73,6,208,23,219,8,242,136,28,79,76,247,206,40,232,226,5,73,119,233,30,110,50,202,204,175,127,33,119,22,239,232,186,27,252,136,92,233,106,222,117,45,179,238,206,104,219,22,101,32,29,204,156,250,4,113,30,88,227,48,134,142,245,126,3,202,217,192,74,163,161,191,71,108,28,167,24,124,175,147,238,127,247,73,168,96,211,97,104,186,223,90,248,173,178,221,127,237,200,185,61,59,185,65,170,180,140,98,130,168,80,90,81,11,162,190,127,108,62,53,16,50,229,192,126,94,244,174,189,131,124,18,218,210,78,61,31,243,203,203,126,120,33,38,195,60,32,96,244,141,53,37,223,254,247,15,158,22,147,61,252,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7a0a820-d8a1-46e7-b253-7496058e4918"));
		}

		#endregion

	}

	#endregion

}

