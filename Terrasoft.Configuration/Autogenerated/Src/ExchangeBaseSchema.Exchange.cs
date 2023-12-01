﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeBaseSchema

	/// <exclude/>
	public class ExchangeBaseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeBaseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeBaseSchema(ExchangeBaseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66fef3f9-d58b-4b77-989b-61a23b76a1af");
			Name = "ExchangeBase";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,91,91,111,219,184,18,126,246,2,251,31,88,31,96,33,3,134,210,243,186,142,189,200,165,233,49,144,180,69,237,108,129,83,244,65,145,152,88,167,186,45,73,57,245,22,254,239,59,195,139,68,201,148,108,119,147,158,237,162,72,98,153,28,146,51,223,204,124,51,212,146,44,72,41,47,130,144,146,37,101,44,224,249,189,240,23,155,44,244,95,125,9,87,65,246,64,127,254,233,235,207,63,13,74,30,103,15,100,177,225,130,166,147,214,103,255,34,79,18,26,138,56,207,184,255,154,102,148,197,225,206,152,235,56,251,163,126,88,175,117,145,167,105,158,185,191,201,238,227,135,146,5,40,216,61,128,81,255,242,188,243,171,87,153,136,69,76,121,231,128,171,32,20,57,235,24,129,74,168,159,27,109,144,41,185,137,67,150,203,33,230,161,255,129,222,45,40,91,199,33,229,254,101,32,2,152,7,51,79,78,78,200,41,47,211,52,96,155,153,254,188,92,81,114,23,112,74,194,36,224,156,228,119,255,3,197,17,14,107,173,88,158,197,127,202,195,146,199,88,172,136,128,161,213,178,28,54,26,192,74,70,236,137,37,183,40,239,146,56,36,193,29,23,12,78,164,69,155,169,231,184,218,175,100,254,158,166,185,160,115,176,5,76,249,42,55,56,248,23,163,15,184,30,168,26,230,150,168,13,254,43,121,199,96,96,40,104,164,6,21,230,99,67,164,135,250,65,105,139,112,69,211,128,112,249,107,92,141,241,241,59,18,195,143,49,89,198,41,253,111,158,209,121,118,159,19,97,125,24,17,196,214,96,160,101,76,181,148,137,124,40,5,76,165,8,245,32,190,39,30,126,34,47,166,36,43,147,196,204,30,128,202,41,174,65,214,148,113,60,143,154,229,47,130,123,250,154,138,223,131,164,164,167,102,208,204,107,108,81,45,237,95,7,92,220,228,81,124,31,211,8,71,141,212,146,131,223,43,137,246,33,16,155,176,150,192,103,87,44,79,111,69,232,233,181,253,101,126,155,197,248,33,72,240,107,111,52,110,30,89,9,222,226,207,173,182,2,205,34,101,136,166,85,192,14,5,44,2,248,236,177,9,216,13,241,169,173,27,161,14,229,19,255,85,90,136,205,164,203,132,183,34,78,98,177,153,167,69,210,126,70,190,146,7,42,38,100,11,178,50,250,232,154,226,141,38,71,108,93,194,83,125,223,118,9,249,64,34,84,26,54,206,156,136,223,133,188,193,124,19,109,242,135,194,4,158,64,254,97,105,74,63,218,246,108,5,76,247,71,105,54,19,225,126,152,84,236,97,187,89,199,76,148,65,98,108,2,214,168,54,99,160,138,24,214,6,154,243,55,0,226,183,76,26,202,51,6,28,85,168,30,88,54,197,147,249,243,200,87,251,155,71,26,157,91,245,139,81,81,178,172,194,128,133,176,65,156,9,202,50,220,83,181,135,237,62,37,160,47,144,84,59,3,137,192,111,80,17,244,139,145,116,136,42,42,151,52,14,180,99,150,120,141,130,15,49,202,37,229,33,139,11,25,25,211,160,40,80,183,237,136,41,253,189,119,71,173,120,165,127,253,141,109,45,90,91,224,2,103,210,132,166,52,19,251,247,178,144,195,213,207,214,46,14,89,253,76,230,91,2,255,48,79,212,234,64,229,28,188,7,45,68,255,250,134,93,92,198,188,72,130,13,65,22,113,148,111,232,137,111,96,222,174,147,104,60,67,232,182,134,121,71,68,206,27,42,86,121,212,31,54,193,104,33,89,226,34,146,39,108,230,144,2,131,44,164,167,203,153,204,109,16,226,5,96,158,132,234,247,152,92,231,97,144,200,16,147,152,191,198,230,56,42,111,225,54,71,234,8,143,43,202,128,82,65,226,237,32,37,234,143,141,62,242,18,60,76,45,95,167,186,106,149,106,206,199,122,153,79,32,173,204,4,153,78,201,203,42,98,172,3,166,119,2,33,67,239,219,191,229,148,193,89,50,69,208,244,178,10,253,55,65,6,142,204,128,179,9,115,250,115,165,107,235,60,58,212,152,253,129,100,111,57,82,223,251,23,140,2,124,149,72,207,189,96,123,190,191,0,171,210,123,160,140,101,154,201,204,204,141,101,7,245,137,207,162,232,45,123,79,193,246,161,189,153,177,68,173,90,79,47,254,134,62,122,70,246,200,64,4,60,128,83,91,43,102,4,78,135,19,244,171,246,227,203,79,173,77,75,66,172,189,100,106,121,142,127,91,96,120,116,170,168,49,87,109,217,14,204,26,227,13,179,111,219,40,189,203,243,132,204,249,37,56,52,124,4,48,3,193,228,52,242,118,80,55,134,60,117,239,66,168,193,6,2,74,197,154,233,180,14,63,190,150,60,178,211,211,65,184,123,97,227,110,176,87,159,78,229,169,197,157,169,12,200,40,117,104,235,62,0,187,186,85,213,138,47,237,216,161,183,170,229,188,112,166,96,121,128,69,41,41,249,136,252,70,236,207,200,160,163,253,41,129,10,78,98,198,224,96,235,0,180,148,82,17,0,64,2,25,159,149,81,76,250,52,65,154,136,224,129,12,35,101,135,97,71,12,149,79,138,128,5,169,140,180,211,161,246,181,225,172,157,132,140,19,158,158,200,225,238,217,202,92,209,112,102,232,78,4,27,193,108,207,42,26,214,216,107,191,52,166,105,135,75,156,43,77,59,88,149,45,223,50,105,14,20,12,176,2,102,141,255,164,111,147,232,70,171,211,29,159,95,151,48,92,31,13,2,133,194,129,217,156,1,128,12,145,20,171,85,205,110,23,242,67,87,240,242,85,156,242,134,134,91,13,71,62,18,126,111,8,101,45,238,2,183,132,21,223,80,199,125,255,3,6,126,111,120,173,85,60,2,140,189,250,3,78,224,41,73,254,59,60,40,216,154,105,63,3,194,167,103,158,101,17,138,5,215,172,92,167,111,250,16,189,104,13,81,101,216,148,96,237,20,224,157,139,142,233,172,230,155,1,215,90,80,30,167,53,87,48,186,238,174,42,96,156,42,140,61,212,104,116,247,234,11,13,75,176,102,95,226,225,37,163,151,231,245,35,175,230,186,150,44,136,234,17,69,57,202,76,190,146,76,223,203,199,94,189,146,69,148,49,106,189,80,243,124,28,103,9,54,46,175,163,140,9,51,131,214,233,244,100,136,26,86,98,58,85,103,158,217,58,109,68,171,109,85,167,26,100,74,173,25,76,88,186,192,84,22,135,129,25,230,95,197,89,100,230,225,80,207,222,207,168,230,0,182,56,29,121,103,86,224,189,7,70,17,132,43,72,55,77,146,209,104,157,248,45,168,214,81,9,28,209,94,160,86,154,25,225,75,24,235,188,1,197,119,38,70,59,185,99,210,158,163,142,113,228,164,69,176,174,24,158,173,221,61,209,150,4,42,175,128,34,72,144,36,59,241,70,102,33,202,235,136,214,83,39,60,75,144,133,229,212,252,42,222,247,6,215,86,240,131,19,86,57,93,69,5,174,114,231,62,134,74,117,26,30,219,52,95,233,202,88,249,58,230,226,84,241,18,5,151,153,230,19,28,172,102,230,251,186,61,162,70,112,101,159,10,117,246,108,67,60,227,204,136,217,69,169,12,190,21,129,147,69,101,131,13,215,188,193,175,99,224,167,26,150,70,239,215,249,3,182,82,60,139,75,188,201,51,205,14,47,99,166,35,206,101,254,152,37,121,16,65,88,188,45,240,143,177,137,9,195,78,197,26,64,125,125,185,149,160,250,250,239,237,112,172,31,142,119,88,133,1,236,160,62,85,205,116,212,36,39,164,7,131,78,80,95,172,104,248,25,236,6,222,143,133,93,160,131,60,137,57,201,147,232,80,232,70,37,197,10,124,56,195,126,35,124,80,85,124,222,148,217,143,223,6,250,187,33,175,194,43,159,93,37,192,99,32,170,65,148,19,24,203,205,254,139,34,135,8,160,144,175,142,112,122,98,230,56,201,46,228,121,147,217,188,170,139,160,207,163,44,220,194,125,35,181,195,215,64,147,215,177,74,33,85,171,207,72,92,88,223,143,234,224,140,1,203,60,158,84,194,74,72,96,0,20,60,14,250,132,45,27,51,197,173,245,181,9,93,178,214,72,139,156,9,189,34,64,26,249,2,76,183,165,249,115,199,152,73,163,46,112,9,153,25,61,76,186,113,244,94,233,214,2,142,169,74,16,206,212,116,215,44,187,140,209,17,67,236,193,1,62,212,215,145,33,104,49,154,235,25,131,164,217,143,138,147,85,239,207,208,196,157,158,83,175,48,28,68,35,36,162,144,211,225,44,119,69,90,169,97,76,212,183,13,169,133,234,82,110,112,48,181,215,62,56,178,95,55,40,189,123,170,65,251,89,219,34,157,158,160,227,35,96,12,149,74,43,127,248,16,139,213,133,50,144,225,10,238,68,208,108,139,218,74,214,52,217,168,202,217,213,48,14,85,133,105,187,51,97,188,76,50,36,217,190,177,203,105,157,46,22,246,0,107,222,147,244,38,44,226,171,137,82,93,119,31,221,151,144,212,209,81,190,214,139,64,237,154,109,60,240,142,41,36,72,221,191,217,204,35,95,242,106,238,25,77,2,229,252,229,23,195,71,141,129,175,168,8,87,232,186,151,231,246,64,157,207,234,94,134,157,21,167,123,122,28,19,171,171,193,47,74,40,54,51,25,138,222,62,102,180,135,126,91,35,49,155,11,112,12,100,190,211,26,141,160,233,229,166,160,145,205,128,17,44,192,127,165,108,139,254,186,210,157,99,51,191,237,182,74,160,142,110,101,109,45,242,169,114,251,240,16,175,145,221,112,87,166,239,74,231,221,169,191,163,103,85,227,103,108,25,183,106,134,225,45,64,211,137,166,149,211,202,203,56,94,93,46,158,213,145,250,2,47,246,100,83,238,25,40,209,65,122,235,219,148,81,104,169,12,45,117,250,178,214,233,160,147,60,237,109,172,57,241,214,53,184,217,252,27,60,21,62,191,183,166,157,60,116,31,24,213,21,233,206,65,173,106,216,217,78,169,242,70,157,22,170,42,180,42,153,183,142,214,234,247,118,219,44,23,160,141,50,139,84,225,176,233,243,225,125,186,178,178,198,238,29,128,250,56,171,53,99,181,252,119,242,207,222,134,174,147,232,119,18,181,239,83,158,54,153,87,187,66,61,142,120,253,205,82,183,166,59,21,241,63,154,213,236,105,127,59,169,204,91,213,217,213,125,184,154,15,216,146,253,37,219,192,198,244,125,246,198,115,92,134,251,186,215,103,198,140,73,94,86,82,235,108,255,148,158,82,81,73,40,42,204,74,79,231,11,251,73,103,101,146,93,106,137,45,70,78,77,115,211,95,230,170,157,8,107,89,78,228,188,167,121,22,5,97,196,120,22,37,125,255,128,161,58,3,88,88,235,226,204,196,192,4,187,151,27,92,241,51,120,19,30,171,213,6,123,190,136,98,215,47,141,7,167,225,108,201,128,64,158,132,51,220,177,221,6,216,191,223,49,129,233,242,174,71,206,207,197,138,178,199,152,219,145,177,167,133,0,198,169,223,117,186,150,139,92,229,12,143,228,10,43,173,155,161,158,201,149,105,207,172,2,226,71,51,152,61,91,249,194,112,118,202,41,37,33,68,208,233,176,246,185,225,201,204,46,84,59,236,254,195,152,185,167,17,138,33,95,135,133,23,13,90,169,138,175,81,235,173,132,250,14,82,251,49,86,98,43,154,20,178,250,146,108,88,189,87,184,193,138,74,7,134,218,62,148,253,71,142,157,153,150,145,185,146,84,34,252,139,32,179,171,215,121,166,91,240,64,204,60,36,102,238,242,14,130,76,221,60,129,1,15,170,245,63,60,6,164,79,142,78,170,75,229,6,194,212,177,108,116,169,38,211,161,157,200,111,10,75,136,209,163,142,56,86,102,254,6,76,170,243,53,241,40,91,46,70,27,189,61,76,196,226,217,255,15,139,234,254,141,151,9,222,142,118,34,210,92,240,32,36,235,83,125,11,48,229,121,213,130,213,209,76,250,175,28,87,67,166,109,45,69,83,181,104,79,222,226,65,86,31,169,114,219,228,121,254,57,46,10,26,249,80,59,153,157,186,114,176,218,194,94,95,249,192,98,33,47,147,96,15,169,130,96,74,57,199,214,159,200,101,187,59,201,31,142,142,221,173,240,171,145,209,31,127,109,65,200,58,149,82,103,64,129,31,26,87,98,89,199,27,198,253,18,35,67,178,118,93,174,250,170,95,130,82,208,112,118,37,127,239,73,67,236,129,155,145,164,128,122,84,94,80,243,174,123,49,253,158,135,188,31,179,169,98,95,192,175,84,212,34,145,245,113,52,9,212,111,143,168,237,143,137,220,128,121,75,251,227,39,130,91,53,64,109,211,85,107,141,90,106,37,73,206,252,65,1,246,79,48,230,17,134,217,9,32,71,23,18,221,86,219,255,194,225,190,151,157,175,226,36,225,228,252,221,141,243,221,24,165,75,44,102,219,149,53,88,203,136,64,28,172,229,155,115,230,70,79,23,220,242,158,91,126,62,236,93,221,190,66,30,119,184,255,42,228,168,212,220,254,255,20,164,213,81,31,85,225,238,182,125,87,109,63,217,171,102,247,235,70,150,2,205,112,173,71,60,180,214,101,159,37,254,225,234,172,105,241,193,47,178,186,222,231,71,204,195,63,248,239,47,159,21,178,125,37,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66fef3f9-d58b-4b77-989b-61a23b76a1af"));
		}

		#endregion

	}

	#endregion

}
