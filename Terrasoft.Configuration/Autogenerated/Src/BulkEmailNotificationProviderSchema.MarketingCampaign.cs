﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailNotificationProviderSchema

	/// <exclude/>
	public class BulkEmailNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailNotificationProviderSchema(BulkEmailNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36980980-5c31-4ced-b403-cc72d034ec69");
			Name = "BulkEmailNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,118,129,254,15,156,10,20,50,22,200,235,107,157,26,112,155,52,240,214,54,65,236,108,15,109,81,48,210,57,225,170,15,143,164,50,120,65,254,247,29,191,100,82,150,100,247,97,235,67,99,146,247,187,239,59,30,85,210,2,196,134,166,64,86,192,57,21,213,90,38,239,170,114,205,238,106,78,37,171,202,231,207,30,159,63,27,213,130,149,119,1,9,135,228,236,237,180,57,90,110,133,132,2,247,243,28,82,133,19,201,5,148,192,89,58,237,129,183,177,184,198,157,23,28,238,16,77,222,229,84,136,215,228,109,157,127,63,47,40,203,63,85,146,173,89,170,85,186,226,213,3,203,128,107,192,100,50,33,167,162,46,10,202,183,51,187,110,80,164,244,96,100,99,113,137,131,77,60,220,166,190,205,89,74,82,37,119,88,44,65,181,168,128,174,163,19,178,232,86,116,164,156,216,24,247,158,65,158,161,117,87,156,61,80,9,218,142,209,198,44,72,138,190,147,68,72,174,92,115,113,125,121,115,245,237,211,252,227,57,121,67,34,159,119,52,237,5,57,242,198,138,200,248,118,244,2,202,204,168,96,215,206,217,10,205,235,84,86,92,105,165,61,97,149,50,94,25,244,71,124,35,128,35,139,210,4,158,212,193,114,172,216,140,94,147,91,116,89,220,58,34,218,43,79,63,32,234,140,105,36,198,236,212,24,123,66,170,219,63,145,221,140,108,40,199,92,150,192,69,32,210,219,246,196,13,121,3,133,109,128,75,6,45,95,180,51,77,111,92,240,170,222,144,18,69,36,13,141,159,86,206,44,23,79,77,174,245,24,221,129,180,191,70,28,100,205,75,47,218,58,184,74,213,198,61,157,210,155,148,60,90,129,79,72,216,43,191,91,114,159,159,62,130,188,175,76,26,87,18,67,0,153,75,100,187,36,213,3,86,60,234,71,30,42,150,145,121,150,97,123,168,139,82,196,75,80,93,130,8,253,199,198,101,100,86,70,161,196,80,198,209,53,20,172,204,80,243,232,132,68,139,44,26,39,115,17,235,31,67,132,102,177,98,5,88,128,191,49,4,196,228,148,52,149,141,160,230,208,59,24,194,159,129,72,57,219,232,2,53,28,130,157,22,116,87,160,190,113,205,110,135,176,0,161,98,105,49,43,38,243,125,211,176,177,46,211,123,40,104,139,250,188,148,76,110,205,145,217,110,1,253,218,19,75,144,18,205,19,138,9,114,92,20,244,14,118,145,112,171,169,95,202,61,25,240,107,197,202,21,189,205,225,152,12,248,0,107,121,89,99,225,42,148,182,101,158,161,167,111,74,38,81,246,229,80,228,22,226,252,175,154,230,45,80,72,100,165,44,176,25,89,9,59,223,118,176,95,214,186,205,132,236,247,226,215,171,186,13,67,23,227,173,240,195,177,167,255,46,128,55,253,18,186,227,101,137,71,63,40,116,40,248,62,234,230,216,176,235,194,71,217,154,97,119,228,85,171,78,66,58,75,48,245,50,35,153,151,89,203,18,95,217,213,118,3,126,104,173,65,38,169,147,43,119,17,196,126,81,11,41,146,54,143,230,124,145,141,15,25,24,220,247,139,114,93,145,11,144,215,144,86,60,107,159,196,70,175,142,43,204,252,157,145,172,57,50,58,255,78,243,26,220,189,53,186,168,209,151,204,212,219,180,217,73,86,124,139,166,225,77,215,141,254,220,148,232,87,188,43,107,233,56,88,199,218,206,95,194,223,100,79,95,39,120,164,187,11,78,20,125,18,76,247,249,122,98,168,223,86,217,118,128,216,111,136,14,98,85,68,148,213,206,238,155,116,211,7,74,67,101,111,175,153,126,219,252,58,14,24,236,58,221,128,94,123,77,209,41,247,17,132,112,234,29,212,194,23,238,119,159,99,176,62,189,207,71,15,13,86,123,253,219,92,209,126,102,30,190,163,15,13,50,243,205,6,116,210,235,89,130,84,107,156,41,245,101,77,214,21,39,41,7,170,250,128,231,61,69,34,239,177,196,181,246,61,195,135,222,209,35,152,102,251,38,178,76,163,217,28,85,0,80,140,215,111,162,15,76,200,211,213,12,177,0,179,104,50,115,178,147,211,137,6,251,131,76,216,91,176,63,185,161,66,51,113,165,100,25,184,20,118,252,176,197,152,233,97,186,191,237,93,14,29,167,254,4,209,113,108,239,135,119,212,222,244,253,36,61,252,131,57,193,15,109,103,180,174,117,217,10,29,0,174,187,13,254,17,117,46,143,141,67,119,14,182,194,210,223,170,34,231,97,19,254,32,78,90,150,233,43,34,228,183,148,28,187,246,12,169,221,113,87,92,221,168,236,250,232,181,54,172,107,244,63,174,111,90,126,242,64,19,11,250,210,212,71,178,108,0,166,10,53,160,230,77,162,12,160,188,108,10,209,183,195,205,179,149,102,33,86,184,4,59,204,96,167,245,3,229,228,59,40,153,104,230,207,36,250,22,225,255,59,27,118,68,155,106,131,79,23,211,198,174,212,239,51,42,233,254,29,161,221,28,222,4,202,166,253,134,222,104,219,223,170,189,1,203,107,121,90,27,124,72,50,154,179,127,224,202,170,165,213,75,150,110,59,14,239,55,227,161,228,125,197,11,42,227,232,75,244,248,203,211,151,232,53,121,124,245,132,83,4,218,127,210,226,120,124,9,250,249,173,167,148,72,117,70,208,214,36,147,217,64,61,118,215,136,225,129,61,144,225,112,66,203,20,14,148,139,157,167,176,92,180,7,241,217,106,118,154,208,88,2,8,78,85,32,235,60,55,78,98,107,226,189,147,201,79,230,140,188,124,233,61,170,19,221,30,81,167,223,96,27,71,34,188,170,198,67,180,89,13,152,42,216,54,155,92,209,147,76,200,2,245,137,213,246,120,199,229,115,91,138,205,216,145,226,166,235,43,83,159,62,16,232,54,2,176,19,235,80,251,246,99,34,91,87,221,116,124,178,24,122,132,14,18,28,241,248,60,242,245,185,247,92,233,193,249,143,19,133,243,214,131,184,163,94,171,195,50,155,11,207,17,159,225,45,204,74,149,126,110,231,61,175,10,31,220,28,252,47,47,188,255,230,137,55,74,254,184,7,14,97,108,17,245,1,103,197,75,222,243,238,80,233,154,172,42,84,21,107,87,208,92,161,226,241,184,97,169,95,55,11,113,13,212,87,97,143,205,154,230,2,90,168,182,27,22,131,28,194,186,194,186,164,194,86,130,247,245,199,181,206,176,110,142,110,139,254,151,215,161,161,196,181,54,255,245,209,221,241,22,231,101,93,0,87,223,15,78,247,158,93,51,213,0,131,151,107,211,255,220,199,181,214,185,66,137,120,220,55,69,219,61,127,75,239,224,191,127,1,201,148,164,108,52,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36980980-5c31-4ced-b403-cc72d034ec69"));
		}

		#endregion

	}

	#endregion

}

