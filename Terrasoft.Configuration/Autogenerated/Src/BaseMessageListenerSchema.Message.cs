﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessageListenerSchema

	/// <exclude/>
	public class BaseMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessageListenerSchema(BaseMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("645c500d-09cf-4369-933e-f61699a11f89");
			Name = "BaseMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,95,111,219,54,16,127,118,129,124,7,214,27,10,25,200,148,246,53,105,82,52,110,178,26,107,210,174,73,54,96,235,80,48,210,217,22,42,139,30,73,37,245,2,127,247,29,69,82,38,37,202,74,218,62,116,192,250,144,90,228,241,142,119,247,187,63,36,75,145,21,51,114,177,18,18,22,7,59,143,202,234,243,18,56,167,130,77,101,60,102,28,58,134,227,87,199,93,51,39,133,204,100,6,34,48,127,6,66,208,25,142,33,229,98,193,10,36,217,121,84,208,5,136,37,77,192,99,84,76,179,89,201,169,204,88,177,243,232,110,231,209,64,243,154,229,236,154,230,251,251,122,125,252,134,205,20,187,138,207,224,7,14,51,36,39,227,156,10,177,79,142,169,0,45,16,222,100,168,97,1,188,34,91,150,215,121,150,16,122,45,36,167,137,36,137,34,15,81,147,125,50,105,49,24,220,85,76,106,97,167,25,228,41,74,123,199,179,27,42,65,79,46,245,7,17,18,21,72,8,7,154,178,34,95,145,9,238,151,124,204,241,207,33,193,159,103,180,64,222,60,254,25,164,82,4,120,52,12,108,99,56,58,112,121,254,92,102,41,249,184,208,52,175,145,134,241,213,36,69,134,106,34,62,89,44,229,202,163,183,42,156,51,153,77,51,212,234,99,97,126,121,100,9,43,132,196,13,243,10,17,217,98,153,219,125,28,179,116,133,236,135,119,119,228,195,16,148,115,81,222,135,225,62,126,221,61,93,127,24,238,226,143,230,118,112,26,103,159,225,236,122,61,244,228,212,182,184,18,192,209,205,5,36,202,199,228,99,233,125,119,171,108,245,104,235,92,185,5,138,84,123,166,203,77,76,162,4,72,173,163,204,167,213,220,104,112,145,204,97,65,207,17,153,40,68,79,121,166,221,182,234,61,76,129,67,145,192,152,229,229,162,232,103,82,169,103,189,173,121,92,133,61,106,87,92,51,150,147,115,128,116,60,135,228,211,201,231,106,109,2,111,167,239,33,97,92,45,157,210,92,64,143,77,208,22,75,224,42,84,183,216,165,218,220,89,11,109,71,109,8,30,52,151,154,85,147,98,202,136,245,154,59,166,152,88,44,198,206,68,139,145,187,7,215,253,71,1,80,28,248,17,56,57,19,179,241,156,34,172,242,154,216,124,87,54,221,219,219,35,207,69,185,88,80,190,58,178,3,70,20,73,52,97,92,19,238,185,148,38,143,184,18,206,60,1,68,165,173,193,96,6,210,252,26,112,144,37,47,154,27,33,47,94,144,168,49,166,233,7,135,100,195,221,102,139,9,6,42,69,111,199,167,89,145,78,48,115,31,175,16,46,81,35,128,226,113,201,17,133,82,133,89,60,73,71,58,137,12,214,213,95,177,217,82,115,47,135,228,134,230,37,56,212,235,237,40,26,171,196,193,203,4,65,176,13,71,129,196,22,53,82,128,175,192,200,236,176,161,23,110,48,144,41,122,246,120,6,114,206,2,225,31,244,62,218,23,163,66,16,99,24,34,25,145,115,32,115,141,115,34,233,117,14,29,144,168,70,180,147,197,209,37,47,129,100,211,154,79,86,241,133,116,151,48,228,199,111,51,1,228,39,29,168,207,247,236,34,223,104,55,25,151,37,205,117,188,235,125,25,27,70,214,60,40,32,218,146,9,158,60,33,225,153,104,52,106,160,210,166,140,26,37,157,69,230,28,110,213,255,145,193,212,13,229,86,73,29,215,157,97,141,196,175,48,42,47,51,76,137,9,86,2,212,241,173,242,40,22,64,27,58,122,84,81,69,14,79,35,41,92,3,234,197,155,97,119,109,92,167,84,103,191,218,25,184,186,128,91,99,217,102,4,141,180,117,48,222,36,139,90,117,193,206,94,128,140,134,147,20,171,160,78,247,241,59,202,113,90,34,188,91,246,27,121,139,140,170,199,171,240,106,87,3,135,52,200,227,109,129,28,148,38,191,150,192,87,27,30,181,141,253,85,175,169,120,41,37,77,230,11,76,16,225,149,174,116,143,220,231,100,12,223,207,195,16,250,171,53,18,251,213,183,126,181,244,30,151,190,218,219,195,219,38,35,129,144,163,127,182,170,240,95,65,125,55,64,219,230,247,13,149,205,190,38,210,52,248,226,147,207,144,148,82,133,242,225,33,121,230,230,177,96,94,186,90,166,232,76,225,228,147,239,35,47,233,125,53,243,210,127,49,41,148,149,38,38,41,104,181,154,73,97,183,221,33,250,0,97,169,146,118,175,168,118,105,71,65,46,93,113,29,226,242,253,5,249,32,254,29,241,4,78,156,219,9,76,170,226,228,111,68,80,244,69,113,63,136,95,22,105,111,224,63,80,216,125,19,129,22,30,200,4,247,144,215,155,25,52,2,157,204,112,68,158,146,23,68,170,144,221,111,118,0,189,25,227,21,228,224,102,140,41,103,139,239,35,103,232,157,125,85,206,248,118,97,159,86,155,49,97,175,119,214,213,11,156,162,5,59,123,129,255,241,254,96,188,107,211,251,120,239,133,181,161,22,100,252,254,234,21,81,103,216,234,154,136,48,93,16,141,204,174,83,91,11,144,55,76,157,46,85,22,93,53,1,89,97,181,192,238,186,82,96,53,206,51,76,142,90,1,113,155,201,100,142,231,182,16,66,245,29,216,234,66,98,48,215,109,118,130,39,32,162,39,212,97,107,6,151,171,37,196,19,19,73,251,150,108,48,104,10,68,100,134,34,95,253,187,198,202,248,201,126,173,183,201,209,229,172,71,76,163,148,127,129,24,29,62,61,98,26,209,191,85,76,10,83,90,230,242,155,153,103,93,159,154,154,124,106,71,185,131,145,123,110,190,255,41,51,112,23,88,247,56,225,190,198,189,24,113,123,156,118,106,52,121,96,236,180,74,129,34,220,164,218,210,104,217,193,248,74,38,231,236,246,160,182,80,151,192,199,206,154,179,172,248,77,93,24,212,214,171,26,41,116,135,154,253,131,21,42,175,110,187,154,176,100,198,75,238,190,236,148,62,2,177,226,6,125,172,198,46,25,110,180,107,115,187,158,112,239,214,195,228,156,196,51,201,218,247,82,21,241,93,39,230,47,41,83,138,24,154,172,46,48,0,18,123,250,212,31,93,21,71,231,212,232,180,44,18,252,93,34,34,77,150,173,238,93,162,103,163,209,40,126,41,162,97,189,93,45,97,248,205,42,86,79,207,247,173,107,86,143,184,135,85,173,202,106,111,160,216,244,176,163,7,86,73,179,78,49,153,201,249,104,68,168,48,14,243,234,88,135,135,109,97,187,72,104,78,249,243,172,144,71,237,26,231,221,114,7,27,152,106,70,212,157,139,3,67,241,96,32,13,39,13,108,52,43,123,61,107,160,81,219,118,56,218,230,164,205,246,186,108,36,66,38,81,170,29,249,173,236,230,241,164,186,91,119,210,165,190,162,84,239,17,117,44,134,238,168,154,233,6,57,76,196,41,6,125,201,225,164,80,45,47,246,51,99,90,232,106,103,86,214,0,209,218,191,8,199,116,11,238,154,122,63,120,27,238,168,174,47,255,79,25,95,80,25,181,94,87,118,53,151,176,196,62,196,239,182,101,7,205,89,181,57,126,105,115,174,16,27,55,215,135,136,168,50,207,27,87,132,110,50,173,208,231,42,98,65,232,141,153,229,65,183,248,23,212,198,6,230,177,169,195,233,90,190,105,192,92,65,241,107,160,41,242,185,192,210,12,92,189,86,121,173,140,177,140,126,137,26,72,60,249,152,141,249,66,226,119,76,212,93,132,199,223,214,17,146,208,170,235,59,249,156,192,178,106,58,55,133,79,189,235,197,39,156,51,30,253,56,124,137,51,234,39,97,73,162,244,76,201,237,60,203,129,44,81,130,66,245,45,92,11,150,124,2,105,43,9,54,56,96,253,190,30,126,81,215,81,189,71,24,167,235,183,9,175,197,53,23,26,173,247,64,139,58,23,14,143,13,98,39,226,28,97,240,150,87,143,80,129,50,162,238,151,239,65,219,157,249,113,125,251,229,235,177,251,244,85,219,183,234,217,236,166,155,0,29,152,108,81,25,125,131,72,63,240,108,170,171,85,38,98,206,202,60,37,215,234,68,155,201,140,230,217,63,144,198,195,186,131,148,115,206,110,43,92,43,221,106,53,106,247,71,174,60,187,106,221,8,103,21,25,238,147,171,86,229,30,209,174,106,188,164,120,214,254,5,86,81,203,76,155,11,124,205,239,171,178,222,134,215,160,113,20,170,219,103,2,120,186,223,144,41,153,141,190,219,97,18,108,162,55,182,177,255,175,251,96,174,71,27,131,22,250,147,2,43,207,148,38,16,122,168,223,169,95,250,51,75,214,241,156,143,201,236,94,241,113,208,177,31,28,195,127,255,2,30,6,22,250,76,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("645c500d-09cf-4369-933e-f61699a11f89"));
		}

		#endregion

	}

	#endregion

}

