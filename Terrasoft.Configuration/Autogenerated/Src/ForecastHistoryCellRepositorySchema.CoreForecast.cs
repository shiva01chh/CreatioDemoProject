﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryCellRepositorySchema

	/// <exclude/>
	public class ForecastHistoryCellRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryCellRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryCellRepositorySchema(ForecastHistoryCellRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34a2b5e5-c1f7-89c1-a01b-7b476cc8a544");
			Name = "ForecastHistoryCellRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,88,91,111,219,54,20,126,118,129,254,7,194,125,145,1,67,206,246,50,32,190,12,141,227,100,6,154,52,75,186,190,12,195,192,74,199,54,81,137,242,72,42,141,81,244,191,239,240,102,139,186,216,201,178,62,212,34,117,238,252,206,119,168,112,154,131,220,210,4,200,39,16,130,202,98,165,226,121,193,87,108,93,10,170,88,193,227,171,66,64,66,165,250,252,243,219,55,223,223,190,233,149,146,241,53,121,216,73,5,249,184,182,70,213,44,131,68,235,201,248,26,56,8,150,52,100,46,169,162,141,205,15,140,255,115,216,172,198,146,231,5,111,127,35,160,107,63,190,188,232,124,117,69,19,85,8,6,18,37,80,230,157,128,53,134,75,230,25,149,242,156,248,108,127,99,18,165,118,115,200,178,123,216,22,146,233,149,81,248,243,18,86,180,204,212,5,227,41,154,143,212,110,11,197,42,90,94,131,242,202,161,214,96,72,110,177,202,100,74,250,206,106,127,240,215,17,67,75,46,65,188,208,214,182,252,146,177,132,36,58,137,227,57,144,115,210,29,234,144,28,245,142,175,31,56,221,202,77,161,208,167,6,195,161,124,120,226,74,148,186,180,88,197,59,19,142,41,151,15,237,104,80,209,31,232,20,77,112,139,29,82,6,203,1,49,174,122,225,110,60,223,64,242,245,189,88,151,57,112,117,91,102,89,196,177,52,88,193,154,246,96,108,180,107,46,166,53,39,70,232,135,13,249,29,240,212,230,165,87,213,52,239,68,177,197,242,32,122,48,73,193,30,169,2,151,165,93,144,249,166,228,95,165,237,160,112,49,157,17,14,223,130,189,200,103,102,139,142,205,83,230,28,223,149,92,97,124,191,12,205,187,27,250,116,71,5,102,166,64,216,119,32,238,64,252,94,2,86,81,27,67,209,159,206,206,206,76,252,227,102,2,221,225,23,10,83,135,212,39,224,150,164,86,168,218,242,59,89,131,26,147,31,97,218,203,150,227,53,17,94,148,44,75,65,144,191,87,199,5,198,245,40,78,90,60,245,222,86,22,131,117,79,61,182,34,209,169,48,200,116,74,56,66,201,31,76,175,119,90,195,82,135,165,149,29,178,158,154,156,138,125,22,57,227,61,131,136,67,235,120,52,71,253,16,156,253,97,237,24,60,168,53,98,245,143,0,85,10,254,156,42,123,157,22,168,119,34,165,210,205,163,209,136,76,100,153,231,84,236,102,126,227,211,6,136,247,76,164,99,8,146,34,207,199,123,157,81,85,169,198,9,158,84,244,100,32,193,194,161,77,86,32,215,21,241,13,168,77,145,118,246,37,86,130,204,5,224,179,126,140,150,218,252,61,80,125,130,194,252,248,35,119,165,52,39,163,149,28,16,22,92,49,181,91,166,120,222,86,94,159,180,237,216,207,52,43,97,114,93,178,116,22,181,156,188,57,95,202,149,140,173,13,171,164,105,124,96,59,188,103,119,94,103,123,207,216,13,235,72,22,172,72,95,103,221,218,104,218,190,47,190,253,63,97,163,161,166,117,99,165,211,122,10,9,203,105,118,194,129,145,173,152,182,29,208,197,246,29,128,234,96,202,71,38,84,73,51,242,88,176,148,220,224,40,103,142,200,53,194,116,242,68,110,0,212,50,197,193,185,224,216,217,130,126,201,96,162,95,207,72,130,255,75,15,186,71,42,8,51,186,152,174,134,158,53,84,155,139,131,120,201,85,113,60,95,189,122,72,54,144,83,147,174,237,120,221,156,52,217,144,72,251,209,142,209,89,24,128,137,96,235,144,226,235,174,37,98,15,159,120,41,23,249,86,237,112,104,253,74,108,65,99,227,54,178,132,121,238,55,247,211,42,10,244,61,99,217,52,237,185,200,104,224,152,48,126,0,117,60,177,7,93,202,195,65,14,155,238,92,177,7,207,183,89,135,245,48,44,193,243,13,53,187,175,37,62,83,14,223,235,47,136,178,78,27,93,166,61,69,189,192,180,39,219,163,198,171,140,188,215,120,145,155,90,19,118,37,96,139,254,242,170,7,228,209,101,220,80,149,159,155,118,108,234,27,129,131,99,133,88,36,34,253,182,80,14,236,251,6,113,130,139,39,72,74,5,209,224,249,179,244,64,36,225,32,157,48,190,65,184,169,180,72,200,168,58,23,155,100,161,169,79,183,107,100,186,96,63,108,205,106,72,174,88,166,12,79,232,123,230,170,178,240,193,7,242,221,23,231,64,204,151,170,106,239,136,106,213,107,155,230,61,36,133,192,198,146,77,27,31,133,173,117,139,169,131,154,55,26,128,177,51,156,170,212,94,19,244,167,169,165,61,247,60,61,117,139,140,15,87,6,233,109,90,221,176,88,177,230,248,142,62,25,134,71,50,222,19,190,137,196,241,253,7,244,111,207,218,35,171,18,167,7,157,189,175,68,145,191,176,224,39,133,3,167,17,142,223,167,105,84,185,227,56,49,143,84,247,235,238,55,70,163,58,6,91,111,118,118,12,17,133,23,60,235,162,253,62,103,118,182,186,223,136,62,128,105,63,40,78,127,118,181,191,28,26,248,50,190,42,38,35,35,223,174,174,125,245,103,166,234,13,97,215,35,102,230,30,198,109,71,103,156,24,187,255,29,76,175,233,40,77,59,182,154,72,52,21,252,31,184,198,158,81,149,170,170,137,52,146,194,172,204,87,101,5,207,139,39,5,92,186,191,195,40,251,209,105,157,14,131,79,208,214,11,130,126,239,139,239,76,239,67,171,95,115,154,109,112,80,63,205,145,118,55,220,52,123,250,223,191,15,51,246,34,156,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34a2b5e5-c1f7-89c1-a01b-7b476cc8a544"));
		}

		#endregion

	}

	#endregion

}

