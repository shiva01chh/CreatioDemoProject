﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseTermStrategySchema

	/// <exclude/>
	public class BaseTermStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseTermStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseTermStrategySchema(BaseTermStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec303172-abd3-4907-9813-cab42af214eb");
			Name = "BaseTermStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,85,193,110,226,48,16,61,131,196,63,140,232,5,36,68,238,16,114,88,86,91,113,168,84,169,236,7,152,48,9,222,77,236,200,99,183,98,43,254,125,39,78,72,67,154,34,180,167,118,81,14,204,248,205,216,243,222,216,163,68,142,84,136,24,97,139,198,8,210,137,157,175,181,74,100,234,140,176,82,171,209,240,117,52,28,56,146,42,133,167,35,89,204,121,61,203,48,46,23,105,126,143,10,141,140,151,13,166,157,198,96,233,231,239,206,96,202,112,88,103,130,104,1,223,4,33,227,242,39,203,123,96,122,28,13,25,19,4,1,132,228,242,92,152,99,84,219,37,16,226,50,8,18,109,192,114,12,80,21,36,145,206,65,65,43,170,112,187,76,198,32,118,37,44,182,117,112,119,195,112,91,90,27,197,9,159,69,54,131,237,131,160,223,17,188,28,208,48,17,237,53,88,192,166,109,135,53,148,183,42,121,105,42,123,52,186,64,99,249,84,28,193,134,101,130,112,239,11,123,87,153,119,220,163,37,176,7,4,71,104,32,214,74,85,148,206,155,136,160,27,18,242,254,14,27,115,123,53,248,13,91,156,79,3,63,25,189,110,192,93,211,215,51,72,209,46,253,159,194,200,103,38,11,168,118,156,170,98,238,80,237,171,154,107,251,44,45,119,131,53,46,182,218,176,194,143,94,134,43,229,111,148,180,82,100,242,15,19,38,64,225,11,72,142,23,138,27,81,39,158,151,144,144,181,55,152,172,198,93,249,94,251,228,59,141,131,168,146,251,3,10,235,214,232,38,155,76,171,202,79,159,235,180,222,83,8,35,114,80,124,71,87,99,97,82,151,163,178,52,142,74,229,27,115,30,6,30,118,181,198,239,210,107,204,201,67,86,137,239,233,12,244,238,23,11,31,189,37,250,34,60,184,139,174,173,200,232,94,131,91,40,233,116,255,101,218,154,139,65,7,180,234,192,150,255,35,97,125,157,247,79,77,119,149,225,25,92,239,73,154,122,1,22,76,146,164,73,175,58,61,47,210,96,208,126,147,30,208,30,244,254,150,231,168,66,242,94,194,130,65,235,140,2,43,115,100,181,234,49,144,24,221,140,158,227,141,196,231,44,215,56,250,145,137,148,56,209,94,198,28,76,60,100,100,124,0,255,60,19,228,142,44,236,16,18,201,35,117,255,94,134,234,44,20,149,188,54,135,97,216,217,223,162,191,25,121,151,243,139,231,76,219,158,248,38,130,242,104,211,37,244,16,88,145,122,249,202,179,143,127,127,1,184,84,222,252,43,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec303172-abd3-4907-9813-cab42af214eb"));
		}

		#endregion

	}

	#endregion

}

