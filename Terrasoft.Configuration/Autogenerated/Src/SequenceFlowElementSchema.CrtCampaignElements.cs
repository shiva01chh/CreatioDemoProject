﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SequenceFlowElementSchema

	/// <exclude/>
	public class SequenceFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SequenceFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SequenceFlowElementSchema(SequenceFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a878fedf-6032-4ad4-82e3-1b66ab4e455a");
			Name = "SequenceFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3114fdd2-1796-4282-98ef-60854140c213");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,27,107,111,227,54,242,115,10,220,127,96,115,64,207,6,44,199,178,100,89,222,60,22,178,30,189,224,218,110,176,217,109,63,20,69,161,216,116,162,171,45,185,146,156,93,95,111,255,251,241,33,74,148,68,234,225,164,197,237,7,175,77,14,135,51,195,121,147,9,253,29,76,246,254,10,130,15,48,142,253,36,218,164,99,59,10,55,193,227,33,246,211,32,10,255,246,213,31,127,251,234,236,144,4,225,35,184,63,38,41,220,93,86,126,35,248,237,22,174,48,112,50,254,22,134,48,14,86,141,48,239,30,254,141,190,126,31,173,225,182,6,231,196,254,39,244,179,24,231,201,218,237,162,80,60,19,67,217,248,216,246,119,123,63,120,148,46,204,1,198,183,97,10,227,13,146,69,34,133,189,139,35,52,141,231,17,196,223,99,248,136,24,2,246,214,79,146,55,224,30,254,126,128,225,10,122,219,232,147,187,133,59,24,166,4,236,103,7,38,8,61,230,23,45,223,195,56,61,14,126,64,98,7,215,224,252,62,58,196,43,248,30,110,62,222,174,207,71,8,248,236,99,226,63,194,15,199,61,158,46,22,230,163,227,31,162,244,199,32,9,30,182,112,4,190,135,169,207,80,102,24,121,132,252,212,240,151,22,74,62,248,241,35,76,95,145,18,30,97,47,74,176,252,240,6,231,35,112,155,188,135,254,250,93,184,61,162,137,52,62,192,142,132,133,98,146,24,230,94,228,220,167,113,244,27,68,250,27,197,231,98,145,23,0,252,76,103,82,91,41,64,82,62,248,219,63,71,36,5,238,126,66,33,106,198,107,252,93,20,132,233,119,209,202,223,222,69,73,128,13,189,183,22,97,112,169,74,55,239,117,130,170,255,53,196,119,217,171,23,241,246,33,126,134,54,196,174,170,47,173,18,21,16,96,236,69,209,93,180,61,110,131,16,18,198,24,134,228,85,124,136,24,117,47,234,110,147,251,99,184,122,138,163,48,58,188,14,81,37,140,253,36,21,7,81,28,164,199,215,145,77,134,172,167,51,131,123,20,71,247,91,152,194,53,138,243,235,211,148,93,236,6,69,168,251,81,199,153,201,125,234,199,105,233,220,95,205,159,52,238,114,50,193,110,184,254,211,201,173,238,81,35,118,127,120,216,6,43,176,194,25,137,40,33,1,111,0,75,119,238,87,79,112,231,103,227,40,174,124,136,253,144,97,165,154,133,240,253,65,50,152,34,211,65,214,151,250,97,138,178,29,4,244,236,167,144,206,239,233,15,176,194,243,32,73,99,146,209,73,82,145,90,222,115,41,69,33,203,33,106,9,139,28,133,40,230,151,178,12,249,82,73,96,175,38,5,114,4,226,224,90,9,233,13,251,247,12,124,157,3,115,155,192,251,109,217,41,156,202,183,108,9,63,178,152,39,71,216,30,52,26,162,150,28,173,212,237,215,163,76,3,109,2,167,93,138,12,77,218,216,230,95,27,28,124,3,218,206,222,176,131,135,238,182,77,147,23,107,245,170,151,153,71,130,225,154,58,37,129,135,138,15,171,52,138,177,147,34,238,48,243,81,212,53,10,156,226,96,8,112,141,123,118,38,22,158,52,182,141,63,38,48,31,197,25,57,97,255,44,195,154,57,125,161,187,37,174,191,112,184,224,191,13,96,247,168,222,68,48,112,125,153,209,152,123,30,140,29,255,63,246,226,104,103,197,143,15,131,201,231,205,102,4,38,159,23,26,249,156,145,79,115,72,86,126,161,98,184,184,184,0,87,201,97,183,243,227,227,13,27,224,164,6,162,13,72,159,208,233,109,209,158,227,124,197,69,117,201,213,222,143,253,29,8,209,153,93,159,39,196,235,156,223,220,146,240,176,130,24,201,85,2,17,150,24,110,174,207,5,50,63,191,184,25,95,93,16,28,55,45,167,35,10,99,116,195,33,145,200,217,27,68,112,144,12,232,216,8,132,135,237,150,126,102,231,218,151,243,104,127,252,235,24,175,161,92,7,171,244,67,244,30,62,4,225,250,252,198,9,72,211,4,17,0,210,8,196,100,20,36,68,73,0,164,24,147,127,128,96,157,52,35,69,223,17,36,85,174,243,155,59,242,11,172,50,157,203,240,189,252,60,70,160,32,247,234,219,67,176,30,1,252,121,3,120,158,70,244,208,202,173,151,178,250,3,158,220,33,202,89,30,252,4,230,231,91,66,86,1,165,118,28,108,192,128,135,2,215,215,188,62,156,157,253,154,112,249,7,50,35,250,115,204,103,37,151,25,100,202,165,25,5,36,159,124,80,200,47,232,56,18,40,219,128,167,230,103,193,110,191,72,182,19,173,227,247,206,215,5,73,142,238,54,68,78,197,223,6,255,129,24,195,198,71,100,21,80,249,98,41,212,23,242,201,210,163,130,101,54,34,114,67,140,163,98,144,66,21,105,78,1,84,140,101,152,58,100,44,213,35,106,134,166,120,187,164,37,213,3,237,130,87,144,140,20,104,4,147,116,85,41,65,40,224,75,195,20,146,165,2,5,16,27,97,146,151,4,169,252,16,68,243,116,237,175,123,97,214,131,22,135,240,19,40,122,180,87,100,254,102,192,8,16,174,42,133,21,89,60,206,98,123,0,73,201,16,165,8,63,92,55,248,227,219,53,18,94,176,9,32,113,199,153,135,3,62,161,74,226,148,247,12,45,136,158,97,28,7,107,72,188,14,176,200,162,204,34,209,225,50,219,140,97,122,136,195,60,226,146,8,144,228,30,232,187,232,17,235,38,175,9,156,93,244,225,150,203,61,132,172,34,35,132,49,36,65,35,36,129,135,74,155,49,45,229,150,102,87,15,81,180,5,18,179,47,165,97,194,204,2,20,14,234,146,115,247,98,216,124,139,186,44,177,167,149,16,145,59,91,38,240,202,150,204,211,112,190,18,233,33,62,185,177,187,219,167,199,177,251,59,242,19,201,128,119,147,67,240,150,56,114,240,38,67,125,199,121,255,241,183,48,93,162,64,145,145,189,60,162,5,229,213,173,206,18,247,83,47,75,90,82,37,154,210,156,84,36,192,113,112,13,158,253,237,1,86,185,111,96,153,192,95,86,39,168,255,175,160,166,65,236,45,39,37,20,28,11,144,49,23,183,58,240,200,107,116,55,13,165,209,169,167,134,138,66,78,23,13,205,67,97,187,134,230,91,72,53,84,68,68,93,67,203,91,22,199,149,143,11,53,148,15,200,253,53,180,180,186,53,80,11,52,180,66,180,88,67,57,14,186,105,40,207,114,73,67,43,25,74,5,181,88,67,115,144,178,134,182,242,216,170,161,31,195,0,249,105,148,255,242,81,163,183,47,37,225,162,100,122,100,251,159,113,55,142,239,222,12,206,255,48,23,250,194,244,22,134,50,211,157,169,162,219,154,174,152,51,67,85,38,198,194,53,108,221,114,204,165,246,229,156,244,226,152,202,18,236,188,31,146,134,164,58,9,226,211,204,244,174,4,62,202,78,181,249,88,241,234,175,235,26,92,194,196,161,24,244,243,175,195,241,187,67,250,136,146,132,199,100,252,30,238,80,56,30,224,202,108,40,115,126,84,131,74,218,213,45,143,229,221,39,214,184,75,145,47,70,216,25,127,5,199,45,242,17,187,23,138,146,253,186,6,173,82,41,203,51,219,162,132,133,147,148,181,94,151,196,116,27,174,162,29,153,177,183,208,143,7,245,113,188,162,132,109,248,82,115,233,229,216,169,185,164,213,18,72,100,46,250,124,105,184,166,62,81,44,221,178,20,221,178,39,202,98,190,212,21,52,170,171,211,169,231,170,206,76,100,46,188,83,148,155,75,141,132,102,115,225,193,95,102,46,60,166,94,230,82,89,57,46,206,180,193,94,42,30,183,98,47,237,21,93,217,153,87,237,133,199,254,74,246,66,81,246,177,151,84,16,4,75,88,198,101,237,231,197,84,88,82,217,94,42,22,198,99,235,106,47,164,114,101,17,37,171,8,192,6,149,4,18,11,17,153,192,98,170,45,167,51,195,86,204,133,134,34,198,204,180,149,133,225,120,202,68,85,205,185,238,89,51,117,178,172,152,64,246,202,36,19,42,42,224,248,106,132,208,148,127,201,109,227,146,105,126,107,179,239,30,183,124,54,168,110,39,92,113,85,105,154,55,36,123,176,103,25,142,237,89,170,174,168,150,53,83,244,197,2,177,103,105,174,98,44,167,182,49,241,108,215,91,122,21,246,72,98,88,46,136,79,96,35,175,147,153,11,59,133,122,119,234,105,19,99,162,41,179,217,66,85,116,93,83,21,83,211,53,101,234,205,140,153,233,57,230,220,92,84,168,127,14,226,20,25,9,64,165,112,65,195,9,244,23,165,123,250,228,167,8,221,58,88,33,239,154,128,79,193,234,9,160,243,142,143,184,133,206,96,34,224,239,247,219,35,57,184,82,137,15,246,25,59,61,216,86,157,249,124,97,154,75,197,208,28,93,209,205,169,169,88,198,98,166,120,51,215,153,89,174,171,155,234,164,194,182,164,237,32,25,62,73,30,219,162,7,139,187,13,61,248,153,47,109,207,155,206,13,101,238,33,253,211,231,214,66,89,76,38,142,50,157,79,150,142,190,180,230,232,163,194,15,221,142,111,99,21,52,131,46,244,210,62,22,72,95,193,69,184,174,163,205,28,7,29,130,165,123,40,169,156,163,111,142,169,42,134,173,78,231,230,210,180,12,179,106,67,37,23,193,187,7,174,229,198,125,61,197,190,88,115,171,79,119,66,200,157,167,186,243,169,106,43,222,124,142,184,155,218,158,178,48,167,186,178,112,180,169,189,176,61,103,169,219,85,238,112,163,169,211,253,231,107,112,214,41,249,17,102,55,154,238,44,212,201,68,65,5,129,166,232,158,59,85,76,207,70,121,206,82,51,22,170,171,122,174,163,10,57,235,212,155,124,17,103,217,85,6,110,71,130,21,233,71,246,224,203,214,92,84,231,24,46,78,211,76,69,119,151,22,250,230,233,202,204,65,170,105,90,19,205,116,107,33,139,240,37,234,141,158,18,161,240,205,34,216,19,148,123,134,135,68,172,147,34,148,57,157,170,154,97,42,182,167,161,8,229,232,200,57,76,93,85,177,141,37,10,198,186,170,207,231,142,88,255,26,47,59,79,97,204,13,215,175,198,150,182,180,103,198,84,155,43,26,50,32,148,90,79,13,228,195,117,93,153,78,38,214,82,215,220,229,194,211,91,217,170,94,175,190,68,233,18,166,117,172,201,76,89,77,90,170,137,90,215,25,72,186,212,210,34,195,154,45,12,213,52,150,202,124,102,27,200,12,117,75,177,84,36,24,219,53,150,170,165,89,238,204,168,74,162,190,169,184,199,45,175,61,36,157,244,183,111,89,45,208,183,215,62,236,154,148,230,249,91,69,206,0,126,14,18,105,237,198,165,94,255,244,147,158,220,74,153,249,154,117,124,190,249,70,10,52,182,163,3,82,187,27,48,17,112,40,235,164,163,99,126,138,214,29,47,13,240,139,216,132,188,73,115,252,212,167,5,82,130,83,38,118,127,176,207,251,242,221,239,16,158,35,124,135,128,115,46,134,248,71,140,119,128,191,225,13,81,241,28,147,255,88,133,132,47,41,199,130,5,25,84,102,80,159,130,20,165,119,217,32,190,47,194,165,17,121,191,197,100,190,66,120,164,143,167,88,91,241,190,220,67,201,208,161,218,10,151,110,116,95,86,7,157,61,160,217,223,46,57,228,178,103,85,12,249,135,114,193,217,15,185,232,193,21,67,204,221,42,22,72,221,240,176,35,72,175,90,235,158,155,134,125,37,175,181,114,129,149,46,44,139,221,233,206,100,188,9,187,248,41,23,67,94,186,231,108,229,76,156,174,53,242,214,243,37,88,89,75,90,239,64,171,210,96,30,169,69,129,250,211,211,241,78,182,55,61,45,111,200,216,246,226,171,219,222,187,181,63,48,99,27,102,168,177,187,184,13,211,168,192,41,15,14,2,205,44,7,10,142,50,14,253,187,67,218,64,177,244,237,26,35,180,122,61,93,80,177,68,17,163,205,228,219,159,166,21,86,40,185,188,22,25,141,24,184,241,100,4,207,235,242,139,152,226,94,189,216,12,157,74,43,115,157,31,200,229,76,54,231,141,39,104,92,215,215,115,34,10,106,41,94,191,253,215,112,227,31,182,233,155,250,84,107,162,82,52,36,249,222,18,41,142,79,137,204,36,32,23,56,89,235,177,120,70,199,63,82,170,207,102,46,152,117,37,51,2,88,212,101,197,31,245,152,183,41,220,145,208,87,127,17,196,0,169,43,203,1,235,15,130,114,140,253,30,21,242,233,118,123,114,212,246,198,224,39,164,241,72,250,59,148,144,128,117,145,27,117,125,222,246,9,47,143,203,207,219,112,134,207,61,113,195,121,206,79,20,236,226,134,116,67,68,239,200,202,89,21,129,103,73,210,160,192,0,232,126,165,132,170,12,155,1,80,9,211,31,20,130,90,177,44,107,26,149,14,114,196,221,78,74,81,201,114,164,81,233,168,59,161,18,101,68,163,60,79,26,181,183,123,199,108,64,206,184,228,111,208,200,129,68,155,1,153,25,142,248,36,41,127,135,215,229,5,169,116,99,113,94,52,234,210,159,26,91,135,52,98,177,52,163,166,203,50,18,197,91,84,160,123,106,146,139,136,128,13,51,58,186,96,25,209,122,186,147,30,189,148,158,46,88,186,209,211,146,42,85,183,23,165,86,221,54,146,230,28,163,114,58,50,162,87,85,82,60,162,152,62,202,35,253,40,175,42,69,70,209,150,150,140,36,78,152,105,65,183,103,223,114,2,58,167,14,18,45,108,92,223,237,24,186,166,14,237,20,84,87,139,246,199,55,138,210,246,66,94,225,242,84,18,190,232,95,132,15,58,252,185,223,101,29,3,83,19,226,57,254,5,143,63,69,241,58,25,227,200,92,228,206,119,40,86,5,159,121,119,88,78,170,25,191,103,98,18,178,231,228,130,205,189,32,12,146,167,140,254,174,29,28,27,37,81,56,44,251,164,21,20,176,224,74,239,129,240,48,121,124,207,53,113,201,115,109,6,215,20,188,105,191,38,185,177,49,130,117,129,58,67,37,120,186,141,162,53,91,36,138,215,17,225,12,16,124,249,223,73,100,93,33,76,188,232,129,120,113,57,251,50,33,68,251,227,41,50,248,255,123,76,95,62,154,104,31,188,234,209,32,49,13,186,188,187,7,61,158,220,119,62,231,198,231,248,157,117,0,126,134,171,67,234,63,108,97,46,151,198,54,102,46,131,204,234,249,63,69,160,56,235,19,3,228,182,99,228,196,67,106,248,224,80,250,201,88,126,246,99,142,154,226,9,3,233,217,182,213,20,153,123,171,108,116,93,217,138,250,8,234,42,234,229,140,128,240,26,61,67,217,98,113,45,36,91,159,29,111,109,186,161,4,161,163,229,65,50,198,255,251,31,67,51,250,54,84,68,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a878fedf-6032-4ad4-82e3-1b66ab4e455a"));
		}

		#endregion

	}

	#endregion

}

