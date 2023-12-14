﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationSectionEventListenerSchema

	/// <exclude/>
	public class ApplicationSectionEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationSectionEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationSectionEventListenerSchema(ApplicationSectionEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ce92919-b922-4dd5-a1c8-dd03a4145b7c");
			Name = "ApplicationSectionEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,75,111,219,70,16,62,43,64,254,195,150,57,132,4,4,170,135,162,7,91,146,97,249,145,170,176,219,52,114,122,9,130,96,69,142,100,182,228,174,178,75,42,86,13,255,247,206,62,72,45,95,146,18,31,100,114,119,230,155,111,30,156,29,146,209,12,228,134,70,64,30,64,8,42,249,42,15,175,56,91,37,235,66,208,60,225,236,245,171,231,215,175,6,133,76,216,154,44,118,50,135,236,188,113,143,242,105,10,145,18,150,225,59,96,32,146,168,37,115,151,176,175,173,197,15,5,203,147,12,194,5,170,208,52,249,79,27,220,75,185,140,178,236,208,78,248,187,236,219,22,16,222,160,149,60,1,121,84,32,188,217,2,203,251,229,46,55,155,52,137,168,241,244,114,41,115,65,173,219,24,178,28,85,251,52,123,17,111,17,128,139,67,220,222,211,232,95,186,86,220,158,34,216,104,107,189,178,24,199,109,18,193,61,143,33,85,140,20,189,240,26,100,178,198,164,40,53,84,124,35,96,141,32,228,42,165,82,158,17,199,165,133,201,161,142,193,93,130,9,66,37,173,50,26,141,200,88,22,89,70,197,110,106,239,75,1,178,226,130,188,109,163,188,37,160,130,186,35,160,67,26,150,48,163,6,206,88,2,208,84,114,18,9,88,77,188,25,149,160,179,177,171,209,240,200,72,41,124,234,216,242,23,209,35,100,244,15,172,99,50,33,94,155,137,23,124,70,213,77,177,196,117,18,41,175,143,57,77,206,72,15,15,4,122,214,33,233,8,163,69,186,18,160,129,109,222,174,97,3,44,6,22,237,170,252,93,211,156,26,144,79,234,178,76,148,98,217,162,249,157,160,3,69,111,176,103,247,94,240,13,8,85,218,103,228,189,134,54,134,141,229,123,200,150,24,192,50,116,88,75,92,220,131,148,104,193,4,173,226,131,149,174,202,237,198,145,32,207,100,13,249,57,145,234,231,229,24,172,108,0,206,247,61,99,252,55,62,250,177,118,79,227,127,192,126,132,69,14,83,99,78,118,26,122,131,254,27,31,213,173,93,117,23,221,28,221,38,144,198,42,2,34,217,210,28,204,230,198,220,16,140,108,204,89,186,35,243,27,86,100,32,232,50,133,177,241,119,74,190,36,25,186,186,175,48,137,14,49,248,246,233,51,146,242,176,137,205,213,182,55,212,215,152,173,121,132,196,61,242,114,238,26,152,239,211,120,79,25,202,11,242,133,54,151,206,15,123,80,203,163,224,57,234,66,92,250,97,111,187,12,181,87,38,211,14,235,228,226,130,248,29,203,19,83,222,166,73,237,176,183,231,227,182,145,169,31,4,71,232,223,67,254,200,123,51,96,139,11,209,117,56,85,9,249,31,37,8,124,48,152,177,68,138,218,237,144,188,43,146,152,164,124,205,231,113,64,76,201,39,43,226,155,149,240,230,107,129,45,197,87,66,225,77,182,201,119,65,41,52,16,144,23,130,89,147,102,83,39,75,149,16,254,46,119,57,96,114,177,26,233,12,47,85,186,145,150,98,116,43,120,166,233,153,174,224,55,25,89,50,6,204,90,169,96,46,194,59,96,235,252,145,76,201,207,228,130,160,222,22,179,25,62,112,213,102,126,253,101,161,217,248,149,120,128,13,168,197,240,165,30,52,203,180,135,221,41,225,219,135,206,40,17,93,235,198,227,67,158,54,189,116,40,88,13,13,20,116,177,182,150,26,22,78,97,155,84,108,241,192,1,26,61,18,223,214,141,220,247,255,132,181,159,216,42,245,174,151,230,122,182,51,114,45,159,203,141,150,239,123,91,67,197,200,196,65,151,94,23,236,79,216,44,138,52,173,24,148,17,235,144,181,72,47,78,45,90,97,133,112,114,40,43,226,71,66,218,10,93,43,202,6,207,160,253,85,128,192,131,92,126,53,221,143,180,246,26,113,10,93,1,219,37,220,216,217,184,33,96,120,25,199,120,18,20,25,243,61,85,68,94,189,180,148,4,58,216,83,136,101,2,142,62,25,86,223,45,128,210,77,55,35,101,190,240,9,213,247,202,180,126,30,241,128,42,160,36,136,207,102,95,74,150,156,167,100,46,59,166,139,39,156,31,100,73,64,154,197,146,194,193,84,97,196,173,120,88,151,51,113,210,73,179,2,243,216,17,70,234,15,187,13,216,224,106,7,198,74,120,234,123,243,184,140,178,155,38,155,30,132,56,158,75,133,62,103,50,167,44,130,217,78,101,212,87,7,32,142,157,69,10,117,240,114,10,156,88,252,80,79,50,221,173,165,145,123,45,18,234,208,205,217,245,204,175,220,172,101,253,248,145,227,140,61,205,65,86,47,252,70,89,156,98,171,71,37,73,183,234,177,112,39,215,176,210,27,53,21,199,27,42,104,70,24,250,63,241,164,26,200,132,55,93,232,255,132,47,255,65,186,225,120,164,101,186,85,192,155,234,225,146,80,177,198,201,67,77,201,174,188,157,148,56,30,21,34,137,129,108,57,230,250,79,182,208,28,125,99,128,24,179,67,251,72,206,64,53,71,13,122,41,214,146,84,101,190,196,115,38,172,116,75,37,168,167,138,182,234,22,211,102,139,54,48,58,78,213,153,3,15,37,218,106,135,170,239,78,171,149,69,98,251,144,194,82,79,151,211,136,245,20,208,1,253,241,208,185,107,225,192,41,89,59,133,118,147,156,75,135,225,29,167,49,196,190,119,211,208,246,2,211,155,47,78,245,212,14,143,253,72,78,7,25,88,32,5,66,114,245,115,114,64,29,77,180,165,254,149,81,221,82,81,53,5,182,226,182,107,239,7,55,189,104,207,36,167,89,253,64,54,107,218,94,48,52,152,87,116,99,171,167,3,237,54,97,177,9,140,131,231,123,86,199,11,112,86,226,145,254,24,128,131,184,222,44,81,241,173,246,116,130,85,18,148,90,197,12,223,133,35,145,28,96,119,16,202,209,174,16,213,200,143,80,101,5,15,221,89,163,86,129,205,162,116,244,103,248,86,183,22,188,96,223,145,128,138,84,29,160,226,245,96,106,73,149,148,153,41,206,171,41,249,192,9,213,54,190,31,157,157,138,10,127,160,84,246,15,253,160,245,10,17,126,220,224,240,11,190,99,162,148,53,167,129,59,163,231,56,139,60,247,1,153,227,165,3,232,133,32,83,53,53,94,22,57,199,169,163,249,38,157,232,99,94,189,135,66,245,78,77,160,188,170,130,112,210,123,107,134,145,129,216,190,189,78,236,236,87,97,133,174,77,45,20,46,64,97,250,79,234,237,76,61,170,61,200,213,28,57,176,236,49,9,79,229,7,34,167,166,6,131,15,176,2,129,22,140,68,117,87,237,47,120,33,236,166,185,180,27,47,1,190,148,168,143,29,126,25,127,213,75,192,253,200,208,234,38,167,125,155,168,184,151,97,169,69,105,232,110,150,31,24,140,33,167,27,216,247,36,239,192,87,47,175,114,177,214,125,203,111,96,86,52,52,86,195,125,156,29,214,181,175,32,118,44,183,193,200,31,5,255,246,221,238,251,234,227,100,245,141,19,252,90,56,135,36,23,5,4,129,91,225,253,227,141,89,173,47,234,53,245,247,63,170,45,238,0,203,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ce92919-b922-4dd5-a1c8-dd03a4145b7c"));
		}

		#endregion

	}

	#endregion

}

