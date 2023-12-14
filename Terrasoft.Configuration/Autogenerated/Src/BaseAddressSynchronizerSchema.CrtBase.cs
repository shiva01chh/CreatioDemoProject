﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAddressSynchronizerSchema

	/// <exclude/>
	public class BaseAddressSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAddressSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAddressSynchronizerSchema(BaseAddressSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("916c69d0-b0c1-48b7-a03e-665144f78b0b");
			Name = "BaseAddressSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,75,111,219,56,16,62,187,64,255,3,235,94,100,192,144,187,215,214,118,145,56,73,17,160,105,179,113,31,192,94,10,70,162,29,237,202,146,75,74,105,221,160,255,125,135,28,74,38,41,81,86,186,70,177,189,56,162,230,61,195,249,102,212,140,110,152,216,210,136,145,15,140,115,42,242,85,17,46,242,108,149,172,75,78,139,36,207,158,62,121,120,250,100,80,138,36,91,147,69,206,89,120,65,163,34,231,9,19,175,234,243,243,172,72,138,221,114,151,69,119,60,207,146,31,138,113,255,122,185,19,5,219,184,207,160,38,77,89,36,73,69,248,134,101,140,39,81,131,230,109,146,125,221,31,154,38,114,230,59,15,207,78,189,175,148,165,104,59,144,60,231,108,13,234,201,34,165,66,188,36,167,84,176,147,56,230,76,136,189,47,140,43,210,201,100,66,166,162,220,108,40,223,205,245,243,53,207,239,147,152,9,178,97,197,93,30,11,178,202,57,17,53,167,84,79,81,28,249,150,20,119,100,67,193,39,78,152,138,22,137,242,180,220,128,235,149,240,137,33,125,91,222,166,73,68,34,105,151,223,172,193,131,50,173,118,3,236,217,50,46,221,123,9,127,39,247,180,96,72,176,197,7,242,81,48,14,201,205,48,234,238,163,204,243,96,176,102,133,140,222,224,167,205,138,41,38,218,14,253,212,201,33,10,46,35,112,165,156,70,134,119,80,108,189,152,44,53,54,151,254,107,192,89,81,242,204,166,12,151,209,29,219,80,201,160,132,75,233,7,84,220,176,21,227,44,139,216,66,165,163,83,23,114,134,23,57,223,208,34,24,62,188,248,121,25,15,199,13,15,71,77,221,207,89,22,99,146,186,50,150,23,144,9,22,35,137,91,112,250,128,49,18,113,182,154,13,47,207,191,150,52,93,228,155,45,133,139,154,115,93,140,124,56,217,83,155,37,85,251,239,99,36,95,88,251,139,87,200,173,173,243,243,251,206,125,225,244,233,35,175,95,35,221,32,240,146,204,240,206,98,47,218,65,251,40,166,30,245,243,96,212,146,144,195,209,109,107,105,143,136,113,23,59,120,222,245,186,17,239,78,89,221,111,253,177,239,100,51,51,208,73,216,150,135,46,134,121,160,5,15,50,246,13,240,36,131,59,85,74,222,19,190,46,55,160,43,24,150,86,87,130,251,101,183,169,209,47,165,19,111,247,39,154,150,204,106,162,135,51,233,227,36,95,34,207,27,55,127,94,9,222,23,222,172,249,84,154,9,243,210,180,228,202,103,65,251,165,241,117,177,42,141,57,151,109,76,65,87,71,90,46,51,64,96,154,130,26,65,18,96,164,208,124,73,190,50,128,147,241,176,61,41,234,68,222,239,13,201,160,209,206,220,90,153,203,82,1,96,173,33,173,146,31,78,39,138,173,93,10,53,49,100,56,95,148,28,16,161,168,177,27,111,64,183,136,141,131,1,195,249,149,5,246,146,202,146,160,17,222,131,237,129,3,205,182,159,227,10,141,45,195,199,88,1,26,222,92,131,70,186,148,28,193,51,71,52,38,221,70,249,153,173,7,73,26,176,62,107,168,124,213,163,116,174,112,114,234,135,126,78,79,209,19,20,232,221,110,37,46,119,212,12,222,31,49,127,155,136,66,214,154,209,26,28,161,120,35,174,80,36,116,135,233,164,226,181,111,245,125,194,11,192,27,117,187,245,20,59,237,18,53,39,112,223,186,8,68,80,165,168,149,106,15,108,36,134,190,228,128,29,68,223,3,127,242,154,159,53,25,2,125,189,15,233,194,106,122,148,182,101,27,75,165,79,55,50,217,252,101,46,14,132,76,119,63,73,221,69,88,209,13,150,121,201,173,73,110,70,134,186,150,63,236,182,76,78,107,154,242,140,137,34,201,12,81,237,228,72,253,115,124,4,59,22,121,153,21,124,215,199,134,61,233,17,245,223,168,11,215,71,125,77,121,76,239,161,39,244,114,29,233,142,168,89,39,180,119,230,107,66,171,222,91,239,193,17,173,252,43,217,30,182,208,36,234,109,29,162,184,217,139,91,123,235,13,118,57,123,71,237,211,82,53,206,25,29,85,227,232,100,30,30,106,158,26,96,160,105,152,112,82,55,194,123,202,45,80,185,140,193,87,123,225,3,86,121,85,99,99,144,153,190,41,147,120,30,248,247,59,187,21,117,142,171,225,69,146,197,218,42,23,241,198,170,139,157,37,170,247,67,104,166,152,133,49,201,111,255,6,55,235,238,245,64,134,106,77,180,61,209,121,25,245,78,12,219,108,247,136,255,136,252,156,91,124,255,49,77,74,152,149,129,58,89,58,142,106,1,39,2,127,102,206,236,30,154,68,87,52,163,107,132,140,75,61,166,157,170,192,6,190,157,94,39,78,155,195,170,233,4,149,133,11,206,36,206,161,85,206,206,128,140,58,104,75,64,68,182,50,71,95,7,157,216,126,206,233,202,204,226,142,69,255,192,12,43,236,47,58,228,94,201,36,209,29,205,214,44,238,59,202,50,61,125,182,101,168,49,122,86,249,186,236,214,77,10,186,62,152,221,219,60,135,49,70,71,123,129,140,129,21,227,42,197,86,120,100,222,52,181,29,202,240,36,219,5,17,153,205,201,179,40,188,20,159,80,205,232,113,211,224,161,37,226,134,9,86,8,194,183,137,60,182,188,247,4,92,15,220,149,215,247,121,18,163,148,107,174,100,160,19,191,169,247,72,233,188,161,28,52,200,150,242,113,43,39,60,167,132,199,205,111,98,35,236,47,178,158,131,161,22,4,125,6,101,133,215,178,98,24,216,31,172,104,42,216,168,162,254,124,7,54,117,89,8,57,83,72,18,52,4,217,241,168,37,158,100,113,32,91,156,228,124,151,23,30,102,59,118,150,223,42,116,163,17,161,66,251,94,221,70,55,64,225,249,119,22,149,16,155,195,109,115,145,50,202,133,90,42,161,214,189,95,94,123,22,138,146,102,2,128,246,198,91,46,144,202,6,170,161,87,201,138,4,54,37,100,189,76,211,145,189,235,27,219,183,18,206,140,206,139,194,219,122,49,114,245,223,73,34,107,3,65,185,7,150,20,84,225,251,112,16,26,15,213,183,246,192,180,221,198,193,177,99,129,17,35,183,35,153,108,163,58,88,230,105,184,164,247,85,105,28,254,58,100,24,42,58,62,211,63,162,72,164,68,237,229,103,144,211,107,164,57,106,157,252,223,242,110,21,231,145,19,63,153,216,169,7,48,218,155,22,12,223,92,47,223,65,47,212,95,236,213,85,209,42,122,112,158,123,56,127,189,216,170,33,174,170,179,72,110,120,125,166,55,221,254,52,131,3,229,118,13,38,89,33,211,168,131,206,132,218,34,127,19,158,45,153,172,59,178,173,154,53,104,214,71,8,105,248,224,78,101,26,63,52,242,94,148,89,20,162,209,10,77,170,215,23,60,223,4,94,240,59,34,156,73,252,65,67,173,105,176,233,84,5,67,203,136,166,148,79,33,240,243,30,136,180,148,3,139,22,86,23,66,145,147,20,204,144,3,31,149,67,153,62,127,76,215,169,49,242,16,38,29,127,132,201,216,119,71,185,206,183,57,231,255,89,50,238,14,228,109,139,64,219,132,131,170,154,106,96,47,75,193,47,17,194,115,208,242,26,119,1,36,146,189,184,78,186,8,240,16,215,228,68,228,153,244,63,84,21,162,87,235,230,158,231,22,202,62,0,58,109,239,51,99,128,107,24,3,191,186,196,135,139,138,126,232,119,13,126,79,210,20,67,131,124,117,247,117,212,133,239,57,236,168,167,187,51,38,162,192,176,42,223,170,255,84,247,229,226,189,126,173,59,233,53,4,159,222,166,236,44,225,245,71,225,234,12,235,189,126,3,97,231,162,24,219,124,55,249,55,117,55,128,237,15,231,21,36,60,78,36,35,2,134,54,200,191,50,7,35,227,107,5,6,184,70,180,246,216,202,57,8,209,162,38,108,12,206,58,28,70,128,182,110,205,238,213,96,7,34,115,242,130,188,54,143,149,231,112,181,94,42,16,222,163,149,35,234,153,3,210,246,235,6,216,236,167,246,130,151,85,185,55,152,60,72,227,108,81,120,106,31,194,153,252,247,47,22,200,17,98,229,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("916c69d0-b0c1-48b7-a03e-665144f78b0b"));
		}

		#endregion

	}

	#endregion

}

