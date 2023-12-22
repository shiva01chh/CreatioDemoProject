﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChainOfCircumstancesSchema

	/// <exclude/>
	public class ChainOfCircumstancesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChainOfCircumstancesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChainOfCircumstancesSchema(ChainOfCircumstancesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ed1b5c0-740b-443a-92e9-04d09df2eeed");
			Name = "ChainOfCircumstances";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,75,143,219,54,16,62,187,64,254,195,212,189,104,81,199,139,30,138,2,89,219,197,98,211,20,1,210,116,145,13,122,13,104,137,182,217,202,148,75,82,235,184,65,254,123,135,15,73,164,30,126,236,122,159,109,14,177,77,13,169,153,249,190,25,205,80,92,78,150,84,174,72,76,225,35,21,130,200,108,166,134,23,25,159,177,121,46,136,98,25,127,241,205,151,23,223,244,114,201,248,28,174,54,82,209,229,89,237,55,202,167,41,141,181,176,28,254,74,57,21,44,110,200,188,99,252,111,28,196,225,239,4,157,163,40,92,164,68,202,87,112,177,32,140,255,62,187,96,34,206,151,82,17,30,83,105,228,78,79,79,97,36,243,229,146,136,205,196,253,62,7,185,162,49,35,41,172,5,89,173,168,128,236,26,255,83,11,10,41,227,127,209,4,63,164,26,0,73,211,108,173,239,190,201,114,80,25,160,228,44,19,75,32,86,75,88,51,181,128,56,227,9,179,191,163,216,191,253,137,187,155,90,16,5,49,225,48,165,48,75,233,103,54,77,55,122,150,113,14,77,134,240,7,21,27,144,108,201,82,34,244,109,180,30,177,54,139,197,144,80,201,230,28,86,68,41,42,56,244,99,109,39,100,51,16,232,239,76,178,41,75,153,218,244,7,224,110,54,205,149,81,43,195,207,88,80,244,61,170,111,22,163,18,80,121,160,36,94,192,130,240,36,165,98,88,248,231,180,230,160,145,218,172,232,138,8,178,4,142,200,142,251,31,63,80,153,167,170,63,249,136,23,220,237,241,247,112,116,90,74,234,185,171,124,154,162,210,146,146,20,157,104,110,219,138,204,200,173,167,231,124,49,48,213,241,188,20,236,154,40,106,175,213,49,52,3,31,232,10,149,160,92,25,126,105,157,8,248,254,135,245,130,197,6,30,133,10,72,64,111,169,151,128,134,3,206,123,233,193,54,40,86,36,32,179,92,196,218,99,217,244,79,164,226,192,136,19,152,229,220,32,110,56,32,50,52,64,2,83,195,82,53,223,125,189,149,213,188,176,222,211,72,95,213,81,80,25,251,134,209,52,169,91,91,174,128,240,37,25,71,178,92,34,77,88,140,67,35,171,215,4,62,161,13,23,133,5,103,237,179,172,44,124,50,70,209,14,161,215,52,165,115,61,242,169,48,178,67,176,210,161,192,14,149,64,151,250,90,88,219,40,79,172,121,197,64,129,44,250,90,137,60,86,153,208,38,27,170,56,145,6,192,102,228,45,199,133,73,202,254,65,234,18,224,116,13,136,163,197,214,160,61,146,148,106,146,207,198,125,223,205,253,211,201,16,170,101,79,27,235,142,124,102,91,239,32,177,49,232,236,119,36,117,73,232,150,9,133,159,236,148,54,106,168,142,165,92,116,248,186,70,14,36,43,62,168,224,40,214,61,1,203,152,158,131,17,198,224,227,217,43,97,195,11,33,130,189,128,35,122,30,140,39,128,0,148,83,3,248,154,2,95,31,30,28,223,130,254,4,41,88,70,173,205,170,149,167,49,165,93,83,3,2,70,221,14,4,31,24,242,102,52,251,102,14,96,39,37,44,124,175,240,166,76,70,133,88,147,48,53,248,155,25,227,17,0,124,143,80,52,201,229,211,31,217,133,63,91,232,101,31,116,91,232,117,147,168,30,180,165,211,64,159,189,65,174,197,112,61,37,63,14,152,159,124,28,223,39,121,110,155,31,6,150,26,71,99,216,174,52,114,16,9,59,171,131,223,40,22,173,205,90,168,139,180,215,217,95,212,194,229,160,211,85,91,137,40,66,33,89,130,29,4,14,174,23,184,50,86,247,229,100,166,128,97,57,168,65,160,88,84,167,26,247,72,151,198,214,7,230,119,88,200,3,94,228,153,45,248,58,249,46,168,202,5,151,19,163,155,173,73,203,34,185,184,22,148,86,14,199,75,171,255,149,185,121,84,250,221,78,169,202,178,161,117,16,118,70,234,178,80,93,70,39,216,53,229,92,225,180,241,24,126,176,51,123,63,123,179,94,111,144,175,44,182,14,139,92,17,225,160,71,236,187,4,79,14,70,109,119,57,231,12,165,126,148,153,2,123,78,149,244,194,101,63,55,127,104,247,173,141,39,199,120,64,103,217,111,149,95,217,12,162,111,3,82,151,94,41,101,122,106,33,178,181,73,134,151,158,224,27,194,176,173,249,229,115,76,87,102,158,115,146,246,146,254,184,198,238,237,154,164,185,174,209,106,160,158,85,18,46,37,140,33,114,74,158,152,57,103,129,118,126,252,68,118,70,187,118,190,224,14,245,28,161,236,106,123,194,91,46,38,183,34,91,138,217,204,151,104,110,46,25,71,164,139,224,35,124,163,31,39,94,175,140,33,56,51,10,119,194,237,176,36,83,236,26,176,227,46,26,170,14,115,225,149,167,198,23,216,254,208,219,173,240,202,127,70,237,161,107,208,244,109,33,13,170,217,121,233,8,90,7,143,161,131,213,222,194,166,253,244,174,19,201,141,215,135,183,182,191,173,205,190,126,94,151,91,31,65,114,222,209,133,151,253,235,59,179,177,243,142,73,53,242,159,182,216,197,6,203,97,96,234,192,234,146,54,65,213,169,229,133,221,107,64,32,244,227,196,132,41,7,90,198,16,36,185,121,34,233,84,71,63,211,56,55,137,119,111,253,81,151,210,231,168,182,93,190,138,208,82,243,64,174,84,184,11,3,204,84,43,42,20,163,181,36,222,1,67,205,164,46,237,109,232,158,207,231,194,212,38,21,87,62,214,181,182,73,13,31,1,181,7,159,182,165,57,63,106,152,93,61,169,118,210,173,189,196,104,53,244,60,73,116,57,108,75,62,44,126,93,213,23,135,21,112,177,89,167,178,149,230,165,221,63,148,93,27,67,141,26,50,88,109,226,243,44,40,18,11,42,92,103,44,209,138,189,97,66,170,200,23,15,34,162,120,78,132,188,30,150,19,3,217,51,207,109,71,112,4,58,254,30,29,241,142,220,204,15,102,94,167,27,118,179,199,139,146,226,98,225,93,179,145,156,102,36,145,225,245,171,178,180,220,237,235,96,19,243,118,12,235,110,120,178,169,206,84,126,213,229,123,58,168,180,46,114,33,40,87,54,255,214,10,174,162,127,217,182,199,91,113,246,13,42,80,13,215,91,141,82,76,135,126,208,17,37,116,70,116,17,87,84,76,94,155,226,194,223,37,13,221,202,236,75,233,199,226,230,227,119,149,247,138,158,237,54,119,54,155,183,192,120,80,91,106,59,228,245,240,189,67,10,52,94,146,92,21,27,18,238,37,73,185,147,16,188,36,57,120,35,227,120,251,24,119,195,140,145,51,124,18,185,47,229,222,132,165,204,149,251,117,131,200,111,108,75,60,88,188,63,81,176,159,74,118,169,56,100,240,61,144,72,199,74,66,117,186,29,150,122,158,2,251,142,177,19,251,124,243,87,141,70,173,251,175,55,225,231,110,230,133,91,188,207,48,237,61,3,226,61,209,92,122,7,124,62,86,190,221,206,250,219,21,126,94,107,166,27,190,255,59,179,118,198,152,102,120,103,99,102,164,30,174,47,187,225,190,194,115,239,203,182,96,119,112,132,30,138,240,253,118,101,7,16,224,137,22,234,199,230,197,49,154,178,118,78,220,113,113,242,252,161,126,34,153,229,158,91,178,253,200,118,183,29,217,67,112,239,25,20,198,119,204,188,187,109,200,218,121,119,175,253,216,255,180,251,15,229,209,199,208,142,221,132,243,119,80,240,253,98,94,130,83,9,177,239,234,125,95,241,135,96,153,153,173,7,174,106,103,130,220,77,203,19,65,250,200,77,227,173,242,240,156,111,162,234,200,77,243,250,69,74,137,136,252,151,207,189,234,204,192,251,44,161,181,83,6,133,133,227,218,121,131,161,233,140,237,50,235,5,75,41,68,133,232,183,99,224,121,154,150,74,116,190,233,196,69,221,156,225,31,222,89,34,37,54,229,145,161,239,86,130,204,151,4,214,68,112,125,4,33,97,146,76,241,102,87,63,252,244,99,113,108,204,33,233,175,60,244,14,80,157,117,44,133,62,87,153,8,150,250,10,72,195,120,1,81,245,222,159,86,199,151,166,89,150,2,147,181,227,36,104,4,213,39,86,130,183,191,93,71,78,10,93,204,113,169,198,82,213,173,90,128,67,246,71,116,248,150,115,42,202,209,210,54,119,84,170,87,161,85,56,246,61,253,172,130,243,84,95,125,246,215,219,164,125,246,37,126,95,81,65,154,127,11,209,117,176,68,7,54,39,58,88,212,58,179,129,34,129,113,204,98,246,212,110,198,233,222,109,177,166,92,127,98,95,88,23,217,109,91,86,55,207,134,254,228,202,124,118,205,40,35,177,210,53,105,143,68,169,255,100,103,87,242,204,156,123,224,123,155,54,183,75,27,147,6,123,8,90,91,10,134,4,7,242,76,62,220,54,185,136,129,25,210,93,255,21,85,164,167,7,129,136,41,200,104,50,12,131,220,59,212,105,242,83,247,25,4,71,171,173,119,176,38,220,246,22,205,227,128,237,124,181,163,225,32,142,249,255,254,5,21,227,28,89,253,55,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ed1b5c0-740b-443a-92e9-04d09df2eeed"));
		}

		#endregion

	}

	#endregion

}

