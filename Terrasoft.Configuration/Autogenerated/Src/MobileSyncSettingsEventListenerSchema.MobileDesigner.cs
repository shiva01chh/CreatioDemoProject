﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MobileSyncSettingsEventListenerSchema

	/// <exclude/>
	public class MobileSyncSettingsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MobileSyncSettingsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MobileSyncSettingsEventListenerSchema(MobileSyncSettingsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("350f87bf-9728-470c-ac11-241cbbacc291");
			Name = "MobileSyncSettingsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7f59f1d3-d5d6-45c4-8743-c7152da9862d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,89,221,111,219,54,16,127,47,208,255,129,81,129,66,6,12,101,123,77,154,22,77,226,118,14,154,54,171,147,245,33,205,3,45,209,14,23,89,116,73,202,169,81,248,127,223,81,212,7,73,81,138,146,108,19,96,192,34,121,199,251,228,253,142,202,240,138,136,53,142,9,186,36,156,99,193,22,50,58,103,115,154,146,217,54,139,103,68,74,154,45,197,203,23,191,94,190,64,240,228,2,94,209,108,43,36,89,29,154,67,203,148,205,113,122,112,112,194,86,43,150,69,159,216,114,9,195,214,146,207,228,94,178,172,216,225,76,168,53,52,251,97,45,104,36,208,92,58,39,179,5,93,230,28,75,10,92,78,137,160,203,108,70,248,134,198,164,147,130,247,77,69,147,76,82,73,137,24,178,38,154,108,72,38,187,150,106,211,117,76,126,206,105,84,10,122,206,18,146,70,223,200,188,17,92,211,188,226,100,9,106,161,147,20,11,113,128,218,174,40,182,255,68,193,1,25,225,21,213,117,33,221,214,154,11,103,241,45,89,225,207,224,96,116,132,2,155,83,48,186,209,148,235,124,158,210,24,197,106,187,135,118,67,7,232,24,11,226,217,75,243,42,99,196,84,227,130,179,53,225,202,110,7,240,159,110,176,36,205,162,230,223,90,79,161,24,226,67,162,153,228,202,112,167,100,129,243,84,158,227,140,46,136,144,151,100,181,78,213,34,80,230,215,247,224,36,23,146,173,180,142,226,123,112,112,125,51,254,30,40,209,191,172,85,92,168,33,4,203,10,67,159,98,137,167,171,53,227,82,199,78,177,124,55,46,102,243,148,168,181,191,202,87,146,234,183,93,80,187,196,20,112,10,129,141,82,248,29,33,248,7,162,225,37,225,209,71,34,85,192,131,205,131,7,76,24,140,14,125,250,191,34,89,162,45,102,110,90,25,241,156,200,91,150,152,22,108,11,118,118,201,238,72,134,64,18,175,198,225,217,151,249,223,36,150,104,85,90,115,100,122,75,61,37,3,209,88,16,116,172,86,95,155,150,13,110,14,109,82,78,100,206,45,210,119,215,126,195,91,164,59,159,30,27,70,19,4,166,51,169,154,32,10,75,41,87,62,230,227,42,112,72,17,160,42,240,199,232,152,177,148,224,12,193,25,1,89,60,182,5,87,79,73,179,160,169,36,188,109,149,210,108,122,250,28,175,193,40,96,227,15,197,171,158,11,75,82,199,40,116,129,66,175,152,104,239,8,101,121,154,182,246,82,207,28,196,69,11,150,103,9,108,180,192,169,32,135,237,69,11,208,4,199,183,168,178,6,53,185,211,14,235,120,183,171,4,181,57,8,116,246,23,78,115,130,94,191,70,97,168,13,52,10,67,61,56,50,215,142,34,61,22,77,126,228,32,108,216,88,126,212,185,159,214,64,107,40,121,238,83,208,181,126,70,238,45,11,30,169,145,122,182,103,31,245,92,7,74,158,224,6,168,140,192,120,136,102,90,196,75,65,165,67,167,155,96,215,163,129,35,249,117,240,103,78,248,86,135,79,193,188,14,172,199,48,81,201,104,240,80,209,212,67,110,58,44,250,74,224,16,141,73,232,240,116,163,215,124,230,16,109,119,29,243,187,97,49,21,253,129,69,153,197,219,80,251,99,100,69,23,181,244,211,14,251,175,162,202,222,171,229,232,193,148,79,113,37,125,134,31,31,233,7,207,144,114,203,94,97,165,78,59,158,189,7,180,178,69,20,240,157,42,0,161,126,31,121,143,148,14,89,158,157,181,143,205,88,143,19,123,87,119,58,174,151,202,227,172,14,95,116,216,165,176,105,244,62,73,134,36,159,227,61,227,213,91,54,43,171,186,181,233,241,213,205,19,132,146,111,125,238,50,169,74,78,209,5,230,130,116,84,196,29,138,177,84,101,107,242,51,38,5,78,64,196,27,135,128,175,0,214,207,243,229,7,198,87,88,134,193,229,45,225,68,213,37,140,238,57,171,245,65,66,107,39,111,177,4,222,25,202,152,68,115,130,214,74,136,4,97,81,137,5,72,240,183,29,154,112,206,56,252,253,125,23,116,56,90,179,29,35,18,157,19,33,0,218,181,84,240,2,31,95,226,119,131,155,19,72,99,73,42,84,27,78,53,132,45,161,228,20,98,4,37,69,75,163,254,182,204,179,193,92,101,145,166,81,249,121,146,82,200,145,171,140,74,61,54,106,136,163,41,128,105,156,197,238,137,86,211,71,199,44,217,2,147,14,160,61,76,27,64,87,252,130,147,13,101,185,208,161,39,90,96,211,131,204,90,154,21,120,169,134,155,95,201,138,109,138,132,238,1,75,190,229,78,36,170,78,225,81,77,193,46,104,135,45,244,4,164,67,62,7,24,63,82,220,22,181,71,250,30,89,159,37,106,39,66,127,158,14,61,108,245,241,95,212,147,240,129,196,42,129,45,87,123,64,220,120,89,106,36,238,239,118,170,8,28,181,229,117,119,126,16,113,63,132,182,123,133,244,26,241,255,71,71,3,144,81,63,182,233,128,38,221,85,170,210,179,7,110,116,64,141,94,123,122,100,120,22,220,120,12,212,240,91,197,99,20,143,144,131,107,127,87,161,31,122,67,80,92,231,88,167,181,190,224,217,80,46,33,92,202,254,26,111,154,2,116,37,8,7,89,50,176,146,98,149,91,175,99,228,22,24,36,116,157,113,45,250,49,7,198,122,238,106,170,98,77,255,143,224,229,176,115,165,185,208,191,110,141,227,59,40,140,22,203,139,122,204,161,176,101,143,92,209,171,235,26,165,190,190,54,36,137,42,148,211,100,154,205,160,224,3,141,138,183,208,53,65,173,213,184,22,219,117,219,19,119,110,52,25,42,65,59,180,26,11,253,75,66,13,17,197,16,233,25,187,234,145,208,176,175,58,160,198,14,11,119,3,149,214,250,154,237,74,210,180,184,148,117,164,28,69,5,44,209,139,170,64,23,86,209,217,245,228,72,43,228,85,157,41,185,148,34,63,144,52,37,48,173,170,143,23,240,40,40,167,53,47,141,207,107,117,202,179,107,230,159,117,149,245,165,77,156,115,14,58,148,241,101,36,79,139,91,4,32,59,38,160,225,137,69,2,222,104,21,233,208,206,241,177,157,201,163,2,73,26,151,241,246,213,124,179,33,236,53,171,120,76,179,114,63,55,206,186,161,135,190,215,115,21,116,101,237,133,213,62,8,80,177,159,252,164,16,43,181,189,212,193,179,119,84,104,26,77,86,107,185,245,92,243,237,217,180,222,98,87,152,138,51,86,7,146,62,209,134,196,50,216,235,171,77,24,90,129,229,41,55,141,170,232,200,95,204,6,102,169,110,86,74,71,234,208,119,99,221,81,170,167,135,118,125,166,211,221,39,191,211,35,25,13,145,103,113,217,133,61,165,21,42,1,179,199,95,166,5,135,26,235,180,166,233,62,192,251,189,21,25,153,218,170,110,234,105,14,141,39,54,127,234,169,11,110,255,94,213,181,126,177,98,32,76,217,223,223,71,111,104,6,253,58,149,9,139,209,254,219,214,41,11,40,156,115,154,148,253,227,151,12,10,1,156,149,33,211,56,77,0,206,81,45,184,254,200,116,76,20,250,46,190,160,188,231,75,225,185,47,152,99,65,162,154,73,69,221,10,42,205,174,196,120,202,116,122,96,164,9,156,197,189,135,123,141,20,35,123,153,195,67,184,13,111,67,7,249,124,185,93,147,228,132,165,249,42,43,46,208,223,232,229,111,195,96,82,19,180,186,59,117,212,152,252,122,218,52,237,186,254,30,171,148,240,158,241,187,226,74,248,4,240,246,64,33,191,153,52,208,171,188,123,135,130,242,18,161,158,10,156,221,157,83,14,173,156,247,65,103,161,195,115,214,46,179,234,163,149,205,35,50,170,183,90,17,90,26,187,44,173,4,107,215,125,55,175,251,14,98,247,22,164,213,222,139,230,22,198,165,245,94,171,52,215,41,70,207,231,110,218,243,129,172,175,99,174,191,11,58,252,234,239,103,98,146,225,121,74,146,254,16,41,151,67,140,76,43,130,86,28,91,119,146,253,236,102,85,196,105,19,40,169,219,236,58,63,22,118,124,37,52,63,15,238,213,122,141,145,255,214,210,112,146,241,65,52,186,100,90,182,22,72,178,122,43,127,25,232,196,161,237,38,175,158,182,167,138,97,120,254,1,160,107,90,124,190,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("350f87bf-9728-470c-ac11-241cbbacc291"));
		}

		#endregion

	}

	#endregion

}
