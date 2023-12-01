﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataBindingManufacturerSchema

	/// <exclude/>
	public class DataBindingManufacturerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataBindingManufacturerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataBindingManufacturerSchema(DataBindingManufacturerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0bf9239e-1039-4629-bd2b-fe0f3c218abe");
			Name = "DataBindingManufacturer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,89,75,111,227,54,16,62,107,129,253,15,172,247,34,3,134,124,143,99,47,54,175,133,177,72,54,77,54,237,161,40,10,69,162,19,53,178,100,144,82,182,234,194,255,189,195,151,68,82,20,109,39,205,161,205,33,182,169,153,225,204,199,111,134,67,170,136,215,152,110,226,4,163,111,152,144,152,150,171,42,58,45,139,85,246,80,147,184,202,202,226,253,187,31,239,223,5,53,205,138,7,116,219,208,10,175,103,214,111,144,207,115,156,48,97,26,125,198,5,38,89,226,149,249,122,255,39,124,189,44,83,156,119,114,250,244,235,117,89,184,159,16,60,52,30,157,157,12,62,58,47,170,172,202,48,29,20,184,136,147,170,36,62,137,235,56,121,138,31,184,0,136,124,32,248,1,66,65,167,121,76,233,17,58,139,171,248,36,43,82,208,187,140,139,122,5,214,106,130,201,117,76,0,221,10,19,202,149,54,245,125,158,37,40,97,58,67,42,0,83,189,6,204,131,31,92,165,157,232,154,148,27,76,88,12,71,232,154,219,17,207,165,77,90,17,230,243,21,76,135,126,160,7,92,205,16,101,255,182,134,212,125,89,230,104,73,47,74,146,224,187,77,26,87,123,8,127,193,141,75,232,3,46,82,225,154,233,39,80,7,124,169,25,154,110,79,189,113,135,99,152,107,123,128,188,140,187,128,184,65,149,169,5,28,131,57,31,98,139,25,188,208,220,68,0,176,234,176,146,35,79,184,25,154,42,48,177,157,235,218,74,128,225,57,103,70,116,231,44,52,197,168,53,248,102,148,211,85,222,132,118,82,138,39,97,115,155,60,226,117,188,67,227,115,157,165,72,102,220,221,50,245,72,46,207,139,122,141,73,124,159,227,99,239,218,46,144,248,164,30,99,186,135,63,215,152,52,23,89,94,113,3,178,116,33,49,224,180,241,239,173,225,13,166,117,94,237,189,126,74,252,192,181,227,100,190,173,147,4,83,31,38,93,240,199,75,168,227,191,196,121,150,242,125,225,18,244,96,121,22,72,204,47,127,190,26,154,101,1,0,67,104,248,8,45,7,2,214,145,201,148,184,71,58,224,217,234,69,15,241,109,11,210,84,74,132,130,10,218,202,99,185,133,76,118,167,17,218,180,95,199,179,61,169,32,72,231,11,248,183,51,188,138,193,85,229,97,213,108,112,185,10,135,194,30,79,144,44,79,35,175,237,209,248,119,155,103,94,121,228,91,23,155,130,23,25,206,83,70,63,146,61,3,184,146,88,226,135,202,111,201,168,146,160,63,54,214,200,204,169,112,158,227,53,172,198,93,149,229,124,69,90,61,251,193,204,191,85,25,249,65,202,10,22,26,167,66,100,58,157,162,99,90,175,215,49,105,22,106,224,142,66,244,73,89,20,130,17,81,43,56,213,37,55,202,18,151,63,109,197,237,159,98,7,97,169,194,191,80,249,101,235,113,64,198,143,158,21,62,59,93,232,65,220,27,152,115,141,160,7,61,250,248,17,133,253,209,57,151,14,56,105,69,207,212,64,199,87,29,219,118,23,161,16,12,10,252,93,239,9,62,145,135,154,173,81,56,170,13,56,70,19,11,159,241,120,60,243,64,33,217,135,214,26,253,246,69,163,199,159,161,113,11,155,222,115,29,162,190,50,26,2,201,22,85,88,189,30,170,23,55,101,222,140,15,45,230,154,238,168,94,200,18,154,91,98,158,110,167,117,243,18,87,143,101,175,92,56,215,255,6,131,107,5,171,180,28,82,104,17,238,27,245,3,65,199,48,192,5,62,194,171,51,111,218,230,163,77,219,99,140,22,215,157,250,241,148,11,117,58,68,204,183,56,158,170,111,122,97,226,237,10,172,240,181,242,230,164,1,35,33,31,238,102,80,72,9,11,232,215,146,60,241,131,87,75,132,168,111,162,211,238,173,250,206,114,113,74,48,56,215,98,132,40,95,100,4,249,9,255,48,77,72,182,25,174,33,61,164,104,75,17,182,173,140,22,183,154,53,38,209,131,236,37,48,235,58,88,107,198,184,162,216,146,85,24,222,85,162,24,163,132,224,213,124,36,103,235,8,126,214,70,62,154,14,44,167,71,71,130,234,122,164,14,15,38,80,19,100,177,64,14,88,209,41,110,60,199,68,51,192,90,223,57,35,214,173,62,100,144,194,156,77,144,34,240,5,64,93,131,112,134,129,226,227,81,11,165,101,151,118,36,220,52,220,246,72,203,174,196,116,220,35,175,248,98,248,40,225,10,196,212,29,32,124,116,235,177,38,105,43,140,201,72,59,28,12,171,214,18,233,166,101,10,187,102,216,153,150,23,80,97,41,194,127,101,180,162,70,78,222,137,42,198,216,143,226,34,213,203,217,4,101,43,84,148,149,80,131,6,91,52,171,60,136,55,168,118,175,202,251,253,74,165,201,232,94,142,56,115,73,79,146,174,240,207,29,149,87,43,186,179,193,188,114,20,96,182,54,134,103,39,13,155,56,108,103,179,19,206,93,149,3,88,173,208,152,46,90,210,243,245,166,106,194,177,10,34,232,165,57,96,16,93,225,239,236,83,165,219,214,205,54,149,96,62,154,125,74,129,101,137,60,242,86,37,218,187,38,30,190,33,104,234,135,148,94,15,233,164,223,163,133,60,179,239,189,81,24,14,232,199,121,107,70,69,199,231,18,136,7,80,137,121,190,149,157,179,225,161,69,116,114,200,93,132,90,153,137,113,231,96,148,28,69,148,85,9,91,78,242,136,66,175,73,105,16,206,195,202,116,75,52,198,125,221,176,84,48,11,92,36,145,102,61,136,36,189,176,19,105,251,138,187,164,182,240,133,206,77,68,60,211,182,146,190,47,17,207,121,57,159,113,135,166,141,126,193,205,68,30,42,52,207,38,142,208,34,54,45,28,69,106,252,13,206,200,172,8,232,233,228,75,26,121,126,129,166,233,63,149,46,234,110,66,246,72,240,205,43,78,140,11,155,209,162,187,211,65,107,57,120,96,85,231,119,73,10,188,87,229,144,231,222,165,172,171,61,110,163,204,224,186,158,219,184,163,18,219,255,78,99,170,12,203,2,108,31,114,35,71,196,238,168,186,32,44,247,118,150,241,219,248,249,127,206,70,216,63,51,192,241,111,156,202,203,213,209,66,221,178,66,233,67,101,158,66,143,242,250,86,31,177,62,103,176,35,97,48,191,21,111,85,47,99,199,105,157,7,7,110,7,34,230,90,207,159,157,60,235,207,118,216,9,92,187,35,112,242,82,221,151,82,116,47,175,98,248,1,92,221,123,238,223,145,42,13,131,125,59,175,88,93,28,116,80,194,123,231,219,63,255,121,95,17,189,241,69,177,36,131,179,241,229,71,156,22,90,237,188,36,132,177,253,98,197,16,183,95,187,8,85,171,227,54,85,186,55,47,242,173,213,254,141,141,234,56,13,123,178,183,144,183,84,129,25,92,116,250,136,147,39,117,219,117,85,231,249,87,34,122,101,70,145,114,21,154,226,106,47,183,131,222,105,198,86,80,134,58,16,76,19,134,178,118,160,144,106,50,208,254,180,74,69,181,97,234,114,174,215,135,1,70,230,225,193,88,42,0,23,38,36,172,31,91,22,180,138,139,4,203,190,172,23,136,112,232,165,39,127,223,141,134,117,214,209,79,104,70,243,216,29,180,220,189,180,187,90,181,61,176,209,246,234,112,189,110,219,102,167,176,159,94,176,71,179,70,195,218,167,219,102,90,22,107,230,135,191,78,72,249,64,189,97,155,163,85,156,83,172,90,216,27,59,50,115,66,33,181,109,219,86,254,105,109,82,59,183,0,94,29,34,206,99,179,145,217,195,123,212,249,93,145,26,163,237,129,175,171,97,12,254,254,1,241,196,42,65,93,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bf9239e-1039-4629-bd2b-fe0f3c218abe"));
		}

		#endregion

	}

	#endregion

}

