﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeSyncProviderSchema

	/// <exclude/>
	public class ExchangeSyncProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeSyncProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeSyncProviderSchema(ExchangeSyncProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42adbdf4-57e3-4eb1-a1e5-ae81ff848c3b");
			Name = "ExchangeSyncProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,91,109,111,220,54,18,254,188,5,250,31,216,45,208,147,129,133,210,28,238,83,106,111,225,172,147,222,226,242,6,175,221,2,23,4,7,90,226,218,106,180,210,134,148,108,111,90,255,247,155,225,155,72,138,171,149,155,220,245,67,179,146,200,225,112,94,159,25,210,164,162,27,38,182,52,99,228,130,113,78,69,189,110,210,213,174,202,210,23,247,217,13,173,174,217,183,223,252,241,237,55,147,86,20,213,53,89,237,68,195,54,63,5,207,233,171,162,250,212,123,185,168,203,146,101,77,81,87,34,253,133,85,140,23,89,55,166,91,107,81,115,22,123,143,60,196,199,87,235,226,186,229,20,41,119,3,12,183,228,132,188,46,50,94,203,177,230,101,250,27,187,90,49,126,91,100,76,164,103,180,161,30,179,43,214,52,240,83,192,84,159,45,127,173,212,25,218,205,63,205,127,111,69,179,97,85,115,222,150,184,186,222,253,69,177,97,255,174,43,182,172,214,117,234,15,130,201,48,253,201,147,39,228,88,180,155,13,229,187,185,126,126,199,235,219,34,103,156,172,107,78,4,8,224,134,215,85,241,153,145,187,162,185,233,182,136,91,97,60,53,68,158,56,84,182,237,85,89,100,132,94,137,134,211,172,33,89,73,133,176,51,81,166,118,141,103,228,57,21,44,246,9,232,160,202,39,223,115,118,13,27,39,32,6,209,208,170,17,207,128,195,226,150,54,76,238,160,183,5,249,98,197,132,192,73,5,108,156,111,164,228,8,8,100,91,194,180,212,206,114,121,158,108,21,81,146,225,58,100,213,112,20,236,127,132,34,132,2,188,208,243,65,188,211,247,200,169,94,100,153,63,35,127,252,248,48,35,109,147,145,170,190,131,167,167,240,180,161,69,121,85,223,195,211,223,31,62,16,50,253,105,12,187,57,104,167,88,23,140,139,3,92,114,70,243,186,42,119,164,172,93,54,115,96,14,76,139,161,226,211,55,245,29,88,64,246,81,232,165,191,103,85,174,132,169,159,99,146,173,27,112,23,150,171,17,91,243,168,165,82,84,13,121,71,175,217,18,100,185,168,91,120,58,33,255,120,122,128,252,203,130,149,121,168,181,222,62,126,105,139,28,246,209,128,197,47,243,49,12,243,54,131,193,67,60,199,172,42,145,235,232,101,102,196,117,16,210,232,135,25,124,151,218,23,176,62,227,47,80,147,167,57,112,34,196,17,174,48,121,70,174,192,104,147,138,221,217,53,46,155,162,44,154,221,18,76,36,57,74,95,213,215,71,68,90,239,196,108,9,36,213,109,14,222,155,149,225,189,89,87,125,88,245,22,197,169,189,151,114,240,195,176,156,96,211,91,198,155,130,141,145,146,141,83,58,70,17,243,175,218,199,53,107,20,127,66,255,120,24,176,231,69,203,57,88,178,220,25,249,140,187,172,215,228,249,187,215,160,233,2,30,90,161,2,71,196,190,229,27,206,224,249,163,176,47,150,13,218,31,68,155,70,16,234,208,41,235,140,150,106,17,33,163,145,153,208,128,50,111,212,58,127,19,238,176,187,27,86,17,21,51,113,128,250,130,122,1,163,38,180,202,137,161,96,215,83,67,144,146,162,0,164,105,127,225,142,169,153,37,225,172,5,27,170,165,177,111,107,81,192,106,59,103,247,238,102,59,173,120,134,105,109,37,80,133,113,162,64,37,125,221,58,214,25,190,35,127,16,164,71,30,192,202,246,26,244,1,127,244,236,76,198,254,1,219,184,172,138,79,45,115,66,29,68,21,35,32,173,137,125,177,79,165,149,26,228,205,97,58,108,155,150,176,73,233,209,43,237,101,86,66,250,215,132,179,166,229,149,27,89,38,82,80,195,6,76,148,23,18,134,30,71,168,114,185,65,174,116,200,136,120,239,56,165,141,77,99,99,101,99,216,177,233,107,175,104,84,170,75,95,202,21,146,88,198,155,57,9,102,214,229,151,203,38,131,20,51,139,236,249,168,47,230,125,182,243,154,53,55,117,47,61,120,210,32,151,219,28,190,8,194,238,1,79,144,45,229,128,22,27,200,145,104,57,204,224,17,186,221,214,144,159,16,223,144,2,193,79,36,176,200,169,4,193,230,201,20,145,205,175,180,108,217,27,120,156,206,47,32,28,224,7,140,84,24,26,208,58,193,59,154,221,150,1,37,57,209,75,192,183,53,88,157,98,236,180,91,249,5,114,248,206,50,152,152,68,226,174,53,35,203,115,105,238,152,69,229,39,252,97,242,69,177,38,137,55,156,156,156,88,167,148,137,79,216,72,237,44,188,64,136,133,195,13,157,201,45,229,86,56,206,192,149,94,15,220,61,137,208,57,50,252,252,52,72,197,157,157,186,211,7,86,76,3,178,91,21,53,118,0,103,131,216,147,190,235,62,69,151,89,101,55,224,153,233,114,65,203,203,34,215,214,54,113,8,2,216,205,207,113,22,38,233,247,31,140,76,38,150,24,242,162,169,172,218,171,223,33,92,206,134,134,176,10,226,118,113,11,22,161,70,61,152,53,35,251,133,236,79,243,196,97,102,96,172,149,141,178,164,208,124,34,51,140,107,29,140,29,231,210,187,5,129,160,8,38,189,46,56,224,183,236,166,40,115,192,245,37,198,182,171,157,50,120,76,123,188,174,27,243,190,200,109,140,89,42,95,184,69,91,36,25,173,0,222,54,228,10,124,228,170,161,144,235,32,24,224,231,141,116,97,194,245,130,199,217,188,106,203,242,248,73,54,63,228,131,204,135,28,211,185,173,46,132,122,227,185,94,111,58,252,6,137,44,243,233,252,220,225,127,153,15,207,146,66,80,78,127,86,8,8,112,59,207,241,215,69,149,163,207,42,106,125,82,122,155,115,37,87,87,162,51,2,5,147,191,123,51,216,141,28,214,192,94,202,89,64,231,23,214,44,144,206,50,127,190,67,198,146,189,152,44,16,152,178,217,62,65,35,24,139,100,237,158,77,120,176,115,86,140,242,236,230,101,81,54,88,241,169,127,2,111,116,135,40,75,78,151,226,197,167,150,150,23,117,18,44,174,29,70,11,86,133,187,110,113,101,187,232,252,144,37,218,18,253,62,216,81,250,18,196,175,72,137,164,219,134,98,108,230,243,165,134,253,90,176,187,228,233,145,166,141,225,243,59,69,92,127,23,233,105,181,75,142,142,130,172,135,74,114,178,148,121,237,79,125,255,227,135,84,99,134,241,105,204,195,217,81,215,4,81,150,128,44,11,240,72,155,190,214,154,217,1,88,236,26,177,30,62,157,191,66,42,199,130,129,127,114,182,62,153,6,210,153,62,153,31,240,134,186,106,32,175,78,231,14,13,140,74,11,253,254,201,188,144,213,97,22,166,65,131,49,111,11,222,128,41,168,132,136,59,83,201,77,75,16,217,75,128,40,193,31,199,1,115,115,179,107,192,16,221,146,68,179,164,53,54,20,227,148,32,109,208,192,180,111,108,56,179,141,159,189,149,244,222,29,96,68,22,202,222,187,254,81,50,130,31,112,100,173,87,13,104,145,163,65,157,154,0,241,170,55,41,12,30,33,183,82,160,14,146,152,227,234,138,115,94,111,140,11,25,179,55,86,15,254,211,155,152,28,29,76,38,203,10,210,31,45,139,207,204,17,183,137,209,35,77,22,107,40,80,113,165,196,57,157,95,10,169,38,243,98,127,164,125,227,56,189,89,148,56,86,57,44,167,189,177,180,219,147,126,147,92,122,28,18,159,225,64,146,65,157,148,46,56,147,9,220,91,35,241,73,236,135,202,131,197,244,13,203,62,2,214,93,19,23,128,21,85,86,182,57,168,163,134,164,197,49,226,55,69,86,108,177,141,131,176,24,74,150,66,117,189,84,41,92,243,107,138,77,188,193,186,59,150,154,209,66,156,188,236,161,236,88,96,136,226,108,69,228,220,43,242,12,72,31,138,41,87,117,93,146,127,82,113,90,201,93,158,54,13,202,143,137,40,40,36,46,203,70,91,58,255,217,237,119,45,21,119,116,250,214,138,199,109,175,76,228,250,55,253,245,97,250,154,150,66,119,108,160,54,99,52,187,113,17,177,30,72,168,249,225,84,42,114,193,115,246,169,45,56,203,45,73,155,159,100,6,83,108,167,50,201,138,36,228,126,102,233,166,246,141,170,226,22,245,6,228,89,8,112,167,183,28,96,12,45,151,215,21,176,183,160,130,117,41,112,18,223,82,195,91,189,35,216,57,108,233,163,126,120,232,167,201,8,129,17,128,116,3,229,169,32,57,219,114,150,81,212,51,118,152,75,64,203,29,222,18,100,13,209,203,137,222,127,41,31,34,224,213,228,192,254,215,76,39,5,150,143,75,97,48,244,204,50,105,34,233,193,36,102,196,139,240,166,200,67,16,101,176,89,103,36,191,177,178,252,87,85,223,85,234,19,2,164,244,140,149,128,252,115,25,198,7,10,235,30,85,40,113,58,177,46,115,212,166,214,53,98,203,186,90,151,69,214,8,203,131,14,79,71,186,230,9,200,165,207,1,131,153,49,51,216,203,17,128,32,167,234,152,24,172,162,52,122,90,150,201,61,57,153,251,28,224,177,5,22,9,34,185,135,217,71,135,195,156,204,157,173,106,14,217,74,196,244,136,30,7,139,60,48,211,7,68,123,19,205,229,158,213,15,165,24,29,100,96,7,125,45,171,55,154,102,144,67,116,137,1,5,139,90,217,135,154,81,41,161,187,109,182,141,180,235,43,80,211,48,244,83,80,2,43,61,37,37,180,97,87,80,26,4,228,2,199,70,16,211,69,191,186,147,205,122,227,92,119,55,5,196,189,72,97,56,86,95,194,20,126,177,109,4,201,84,238,103,84,202,9,55,215,165,47,195,184,65,90,224,41,206,182,191,16,40,15,112,103,236,231,229,65,193,141,130,125,189,16,180,162,107,246,220,169,156,246,130,30,225,22,142,147,229,139,170,221,48,78,175,74,118,172,140,216,68,51,43,188,33,104,62,137,51,99,107,59,139,54,195,33,26,113,118,153,83,123,80,171,221,0,211,101,192,135,151,31,117,122,92,138,55,80,197,189,133,8,185,109,118,137,153,236,228,57,100,183,168,108,86,83,41,108,210,240,93,191,33,228,249,41,57,9,3,183,138,137,70,122,123,66,123,199,129,73,163,186,156,132,232,157,232,8,96,88,1,229,55,26,51,176,173,68,106,204,252,58,82,71,7,137,125,145,66,100,209,199,164,234,5,192,250,66,184,5,186,100,235,156,137,109,93,57,195,58,65,188,170,175,95,67,250,0,216,149,104,21,42,189,158,42,195,127,35,79,189,240,197,25,128,18,245,238,114,139,153,121,70,166,47,56,135,52,13,22,91,218,208,136,145,39,37,90,100,92,171,8,15,65,167,179,110,27,51,171,206,163,253,64,66,9,104,52,6,6,119,213,71,75,8,43,9,85,64,189,144,24,39,199,56,215,220,192,152,238,208,58,104,153,251,158,171,55,175,114,174,244,223,142,78,206,214,20,53,55,50,142,81,93,211,152,131,175,232,74,176,132,236,164,237,15,15,199,217,252,2,64,24,54,143,16,239,135,65,155,26,50,134,211,25,182,155,36,18,149,83,36,32,187,43,196,225,162,72,2,91,132,6,138,95,197,159,130,138,144,249,45,199,90,192,65,218,210,82,63,57,33,61,41,62,174,85,114,232,168,72,66,2,137,133,20,42,116,164,186,182,41,14,147,155,243,62,168,218,97,196,35,161,67,144,43,14,100,154,112,185,249,203,94,251,97,144,0,38,104,236,96,97,117,4,232,73,48,172,223,100,207,21,94,226,25,145,186,20,130,21,157,113,62,33,219,113,4,219,203,116,184,112,14,172,64,29,17,245,234,98,236,184,73,33,159,75,95,20,93,180,182,109,5,29,225,112,208,243,157,218,225,30,132,19,116,36,221,214,161,247,208,137,140,132,50,156,17,143,1,148,14,49,98,138,3,168,115,70,213,14,146,62,45,59,243,81,208,74,165,99,144,121,86,111,119,170,51,12,113,5,15,131,208,222,84,63,220,57,193,12,29,21,23,93,230,216,123,251,106,157,244,1,43,70,182,92,155,186,152,206,47,224,21,236,189,130,120,128,231,205,81,148,40,139,114,217,30,180,4,254,159,32,77,203,40,180,123,213,86,167,149,223,213,219,111,227,167,149,93,207,211,211,161,102,188,239,12,23,22,65,161,84,142,47,230,135,17,148,111,165,136,89,228,63,234,134,8,36,112,206,128,234,51,127,212,112,11,41,100,161,171,192,20,229,209,71,62,242,252,242,30,28,1,234,127,146,211,134,58,55,15,194,228,8,22,136,167,95,104,214,180,43,191,56,131,12,67,62,178,221,104,32,47,251,254,211,185,238,255,15,107,30,180,126,217,95,105,175,138,85,107,45,247,244,236,152,162,211,202,84,230,28,209,179,61,23,119,143,94,241,156,206,28,192,37,230,135,218,0,81,251,177,231,39,80,3,7,141,84,115,124,48,164,143,23,247,44,107,241,224,122,113,126,121,214,5,108,33,251,30,60,210,13,27,41,108,91,138,32,211,6,147,127,181,46,92,32,49,217,20,57,221,110,203,221,66,90,171,72,34,5,193,240,153,118,15,80,224,141,38,115,242,169,62,116,167,55,81,116,129,0,149,252,249,231,94,200,162,113,74,112,200,227,158,239,184,7,217,177,51,112,196,215,193,225,183,239,186,110,251,206,61,183,234,159,110,107,155,201,187,51,48,188,50,56,245,62,6,71,252,157,56,204,137,179,251,221,105,70,230,32,111,108,11,189,169,49,245,100,218,158,78,66,122,143,186,50,160,200,59,85,145,184,43,100,109,226,163,63,40,167,64,70,174,86,148,99,62,211,95,39,254,134,123,2,114,206,4,77,121,36,21,30,221,82,183,232,224,29,132,225,75,8,210,6,237,90,209,179,250,21,189,117,142,91,145,141,101,117,91,52,138,137,215,117,174,222,93,212,104,128,29,169,7,194,0,115,59,44,122,189,93,73,211,25,108,126,28,190,45,226,95,19,177,110,100,73,185,93,217,158,54,20,249,255,185,54,198,200,92,243,210,141,52,45,72,128,152,117,217,34,77,41,219,211,242,142,238,196,91,8,53,119,128,83,76,87,194,171,203,3,149,188,229,11,76,1,101,249,69,26,250,107,236,69,84,234,41,68,215,140,207,92,113,246,228,190,106,240,14,192,119,42,186,201,7,211,244,117,133,60,74,19,227,84,161,168,119,35,213,179,220,223,107,8,242,23,181,215,115,238,136,251,42,24,39,245,190,216,125,185,63,138,23,151,108,79,141,129,60,35,226,28,86,150,126,25,235,139,80,115,86,23,109,135,188,53,89,28,47,200,189,202,62,171,115,23,241,94,205,250,48,147,200,96,230,6,127,35,83,207,187,205,53,158,88,27,200,234,248,11,184,147,77,155,24,123,236,126,60,115,135,240,205,111,232,21,120,69,246,26,42,23,201,231,163,17,204,95,105,166,198,26,47,251,26,46,132,169,14,231,225,74,92,184,2,237,17,236,190,60,134,166,186,181,9,56,77,37,125,44,39,55,18,136,75,228,11,159,134,167,179,123,217,142,208,77,192,97,57,240,107,49,197,98,136,114,78,101,197,106,78,128,161,4,232,110,76,198,144,158,119,250,229,152,92,20,230,245,160,92,96,137,196,19,163,197,207,106,183,178,102,178,102,62,83,124,9,93,129,188,255,64,112,19,238,61,72,118,143,72,6,29,202,186,132,1,187,192,39,58,96,98,152,8,150,53,235,73,138,198,213,220,208,228,208,145,174,114,136,16,178,235,18,27,91,138,25,83,169,195,63,167,113,139,47,129,250,26,117,5,122,184,20,112,41,239,173,10,76,117,116,33,47,185,90,238,116,25,216,99,112,221,85,146,125,214,220,74,203,187,185,79,22,20,111,230,208,216,189,13,125,235,194,184,143,119,255,61,172,214,156,243,9,239,170,139,126,223,176,129,154,196,86,31,122,229,19,251,23,13,63,255,28,185,252,97,4,230,95,2,209,250,126,76,213,103,171,112,142,77,34,175,84,29,241,71,97,110,38,199,88,179,105,133,108,20,9,0,149,185,89,2,255,18,171,110,27,255,214,71,229,226,132,177,55,47,221,213,190,228,150,199,158,235,34,242,70,214,225,99,177,179,26,59,250,0,40,252,77,144,117,73,175,227,5,189,105,96,159,197,64,82,236,98,115,172,130,112,122,56,135,238,145,196,74,216,88,61,225,86,179,218,104,190,139,93,227,77,251,69,220,15,63,168,208,20,175,128,85,173,133,53,112,236,62,140,199,178,106,65,61,174,225,137,127,22,160,90,111,246,182,128,238,174,126,181,14,230,215,191,11,236,95,197,149,173,191,113,55,113,149,13,197,47,226,246,46,75,140,189,140,251,53,238,127,188,22,215,234,9,47,52,15,92,0,145,87,104,97,136,229,124,207,129,101,120,95,88,95,230,216,115,139,68,85,156,66,180,76,56,132,123,183,147,123,68,93,78,102,68,226,37,162,200,76,157,107,185,49,226,65,118,31,190,155,123,152,145,254,18,192,142,213,232,212,115,137,240,120,74,190,134,255,193,127,255,5,42,9,13,214,143,60,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42adbdf4-57e3-4eb1-a1e5-ae81ff848c3b"));
		}

		#endregion

	}

	#endregion

}
