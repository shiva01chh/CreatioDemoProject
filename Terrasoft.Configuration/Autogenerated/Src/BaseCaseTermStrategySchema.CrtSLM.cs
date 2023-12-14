﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCaseTermStrategySchema

	/// <exclude/>
	public class BaseCaseTermStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCaseTermStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCaseTermStrategySchema(BaseCaseTermStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94f1b8ae-b31f-4486-922e-96e082f6ad14");
			Name = "BaseCaseTermStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,91,111,219,54,20,126,118,129,254,7,214,123,145,1,79,233,115,155,24,232,220,203,12,52,109,22,187,219,67,209,7,70,166,29,110,178,228,146,148,55,175,200,127,223,57,188,88,20,117,177,226,166,107,3,4,176,168,115,227,57,223,185,144,202,232,134,201,45,77,24,89,48,33,168,204,87,42,158,230,217,138,175,11,65,21,207,179,199,143,190,60,126,52,40,36,207,214,100,190,151,138,109,158,7,207,64,159,166,44,65,98,25,191,97,25,19,60,41,105,166,249,102,147,103,254,179,96,213,167,248,85,166,184,226,76,150,203,45,182,196,83,154,178,108,73,69,15,210,249,219,203,87,255,40,150,73,52,203,83,232,36,44,248,134,125,200,184,34,23,229,90,236,22,195,45,206,153,82,240,36,145,24,45,14,84,237,165,35,0,70,96,253,73,176,53,188,32,211,148,74,249,140,252,66,37,155,194,63,152,186,153,43,96,98,235,189,166,59,59,59,35,231,178,216,108,168,216,79,236,51,18,147,4,25,201,42,23,36,193,71,5,140,68,26,78,240,83,236,88,207,60,222,109,113,147,242,132,208,27,164,75,148,21,209,164,154,24,139,252,165,115,71,51,203,64,215,142,166,99,82,114,1,133,68,13,95,180,205,135,205,1,111,145,168,103,4,125,6,8,40,54,153,121,31,110,74,47,24,98,189,35,5,244,36,209,12,100,73,21,141,15,76,254,118,6,91,145,43,0,21,91,226,198,145,215,215,51,64,99,6,13,186,244,10,82,146,2,99,107,213,100,0,242,184,100,168,232,113,142,3,45,24,111,140,254,52,95,50,19,200,54,13,191,211,180,96,39,72,215,124,8,174,193,157,117,38,0,207,248,179,234,92,139,156,114,207,47,193,83,29,254,125,199,36,186,74,7,253,231,36,207,20,229,144,135,167,249,219,32,39,84,221,237,242,107,70,117,1,104,214,214,225,152,82,205,65,134,125,52,234,6,107,166,179,17,254,164,251,117,215,97,200,28,152,191,214,16,39,163,159,33,253,34,137,25,231,178,237,244,88,202,45,75,248,202,224,201,228,242,61,34,90,55,193,197,212,186,224,77,193,151,228,74,240,92,112,181,159,45,143,70,192,103,155,67,217,224,9,155,65,177,60,141,243,10,130,127,95,206,98,187,205,133,122,203,118,44,61,206,122,36,78,175,57,75,151,16,168,43,231,181,174,106,118,90,24,194,0,212,22,102,166,187,182,234,213,141,114,79,100,114,203,54,180,172,59,71,138,39,22,30,195,57,215,140,239,128,239,249,17,208,66,207,212,85,55,23,61,93,50,131,186,201,105,202,255,101,146,128,105,236,111,194,65,4,205,96,176,200,87,68,221,50,96,97,144,144,130,173,46,134,97,251,249,178,168,246,158,197,37,149,127,221,13,207,38,6,185,45,155,212,43,91,42,232,70,187,226,98,88,72,38,192,242,204,204,34,195,201,2,180,226,26,148,1,183,24,159,159,105,142,134,200,132,109,50,250,80,17,71,170,210,71,26,88,207,200,13,112,69,193,43,131,196,187,135,244,86,104,220,55,247,77,77,0,21,107,105,216,224,87,177,97,153,146,15,230,204,49,121,201,245,15,48,255,220,32,118,76,242,155,63,225,237,4,213,73,231,109,117,203,101,179,183,7,77,185,4,227,26,114,199,139,252,189,22,118,30,18,77,162,81,159,110,124,201,212,109,222,183,56,188,97,74,234,16,38,118,172,36,124,9,222,130,122,193,68,87,180,4,83,133,200,228,100,90,103,35,43,145,195,0,168,71,81,34,237,168,9,222,119,44,85,255,239,184,80,5,77,77,141,4,107,76,60,140,208,215,32,200,27,87,35,231,61,35,41,152,118,97,152,87,122,98,9,162,55,62,76,204,186,78,200,216,215,128,195,211,152,44,217,138,22,169,138,208,134,81,197,199,141,62,91,136,61,81,57,110,173,244,154,222,243,28,15,19,108,150,121,77,130,40,122,147,182,21,190,26,108,157,184,217,114,56,129,108,98,130,97,146,129,174,233,225,69,29,247,206,175,215,76,194,38,48,37,243,45,179,195,126,155,215,111,242,60,197,125,128,243,42,206,182,125,209,223,65,4,134,152,232,148,214,185,64,236,96,231,76,126,6,228,98,85,240,203,246,111,5,19,97,30,197,62,193,37,205,232,154,137,49,25,54,41,29,154,40,104,5,165,90,51,226,96,71,0,141,160,55,126,177,180,107,209,208,109,35,6,223,141,98,219,53,64,2,146,189,230,41,20,107,25,191,205,215,28,164,189,119,238,1,41,225,18,228,27,36,119,252,34,91,214,217,65,91,132,207,83,193,32,39,205,234,31,92,221,94,97,60,24,146,68,102,17,78,145,16,35,46,243,108,177,223,194,137,241,115,129,125,98,232,77,29,195,177,105,250,77,117,32,174,76,39,22,143,223,194,16,237,232,30,134,152,97,199,25,98,130,88,158,162,113,108,117,63,77,84,32,17,67,162,0,9,86,20,95,145,168,228,142,103,242,93,174,94,109,182,106,31,141,28,194,6,101,244,65,122,73,252,241,233,39,212,131,219,178,16,208,185,127,142,64,157,68,77,144,25,249,131,153,173,32,158,240,39,23,213,50,208,163,10,192,225,182,86,7,106,101,208,184,144,108,193,135,167,84,129,107,191,10,52,213,232,214,114,48,47,146,132,201,246,194,219,93,2,254,207,204,127,216,132,119,99,167,87,131,3,88,214,26,68,15,240,151,128,245,5,3,104,178,34,77,155,193,234,17,126,103,168,254,112,77,190,108,103,97,79,63,54,1,28,221,43,32,68,250,199,105,157,162,107,190,99,25,97,149,3,201,103,196,105,223,148,4,252,4,185,136,35,47,77,101,110,199,222,90,6,224,204,235,198,228,246,36,5,107,193,61,181,211,127,155,31,171,215,28,184,215,114,69,234,116,173,217,129,208,247,147,86,149,12,54,121,3,161,22,202,193,253,70,72,234,200,6,238,10,170,158,160,78,130,187,166,140,145,204,166,170,237,58,3,115,53,213,201,170,73,44,155,225,186,179,220,193,205,199,9,38,58,9,39,152,232,179,54,152,104,18,248,185,15,109,207,243,71,81,124,37,24,32,6,250,139,48,67,29,133,147,87,6,120,50,103,78,18,5,232,11,47,68,1,124,163,222,208,214,136,25,78,12,114,186,143,85,18,175,87,135,147,169,119,205,11,11,221,60,222,182,225,68,230,37,102,55,155,223,4,27,234,79,123,74,149,198,57,119,181,166,83,232,54,231,118,51,73,71,182,147,24,7,133,119,204,102,235,227,48,123,188,221,90,0,117,52,80,27,92,3,220,208,152,200,235,57,79,140,159,127,165,242,117,74,215,81,213,18,188,223,199,91,55,9,102,111,225,136,195,202,225,201,40,169,166,161,235,166,38,220,77,141,201,156,105,39,145,183,151,184,90,14,98,151,82,214,198,65,253,67,133,242,62,78,232,174,92,108,98,152,54,96,68,149,44,106,178,9,206,208,69,201,230,4,235,146,133,193,44,179,27,119,126,200,109,52,30,222,57,182,90,210,182,239,18,208,209,185,69,77,53,114,2,167,149,49,244,240,96,179,221,26,107,226,25,187,56,44,140,221,104,62,198,104,199,132,90,228,151,60,43,32,104,81,165,199,223,43,198,121,186,11,66,44,131,50,118,90,136,171,229,244,107,67,220,100,211,119,15,113,176,197,175,10,49,134,161,127,132,109,15,48,236,199,135,152,237,54,197,211,197,202,28,248,126,180,17,166,172,160,135,15,120,187,28,170,28,154,189,183,135,212,142,105,228,200,117,110,121,127,165,111,207,59,220,116,109,170,186,247,217,241,208,33,245,183,164,91,46,15,151,222,125,221,212,183,197,245,111,55,230,27,64,14,224,16,208,191,234,77,7,145,235,215,253,166,62,115,239,174,17,116,29,160,14,198,110,239,4,238,81,5,39,139,67,149,169,195,215,226,250,33,206,129,225,117,191,181,173,189,179,130,182,134,209,215,66,11,56,107,56,44,95,213,110,47,88,184,112,194,29,70,40,163,249,38,227,16,183,234,148,17,50,127,124,250,105,236,134,11,127,154,240,103,136,94,149,37,200,47,179,90,93,212,107,248,247,31,38,19,254,12,89,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94f1b8ae-b31f-4486-922e-96e082f6ad14"));
		}

		#endregion

	}

	#endregion

}

