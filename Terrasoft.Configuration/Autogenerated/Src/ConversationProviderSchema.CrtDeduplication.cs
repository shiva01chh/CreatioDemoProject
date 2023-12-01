﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConversationProviderSchema

	/// <exclude/>
	public class ConversationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConversationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConversationProviderSchema(ConversationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb44dd42-c00a-4af9-8f21-866dc391cd62");
			Name = "ConversationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,77,111,219,48,12,61,123,192,254,131,224,93,28,32,176,239,109,154,67,211,108,48,176,118,1,218,174,199,65,181,152,196,128,45,185,250,72,87,20,251,239,163,164,216,179,92,119,77,54,12,235,165,160,196,71,62,62,62,43,156,214,160,26,90,0,185,1,41,169,18,107,157,46,4,95,151,27,35,169,46,5,39,207,239,223,69,70,149,124,67,174,159,148,134,250,180,139,251,8,9,233,197,249,248,85,93,11,254,26,8,207,241,230,131,132,141,109,181,168,168,82,39,4,251,239,64,42,215,126,37,197,174,100,32,93,94,150,101,100,166,76,93,83,249,52,223,199,121,221,84,80,3,215,138,84,98,179,177,45,196,154,192,119,40,140,163,207,128,153,166,42,11,63,140,104,192,143,165,210,182,94,214,43,216,152,123,76,37,133,229,49,74,131,156,144,124,244,252,217,17,236,38,249,88,66,197,112,148,149,44,119,84,131,191,108,124,64,36,80,38,120,245,68,110,21,72,172,198,161,112,228,190,153,32,62,221,151,4,206,124,213,176,5,38,42,45,77,161,133,180,141,28,115,159,49,148,201,29,244,210,211,46,41,27,102,205,26,42,105,77,56,186,226,44,14,233,196,243,28,43,80,142,86,65,129,103,10,128,20,18,214,103,113,56,69,156,205,211,89,230,202,184,170,123,73,199,68,75,6,243,135,253,38,206,121,81,52,80,133,156,145,23,50,69,209,143,223,107,117,9,122,43,216,33,50,125,70,15,1,35,37,95,11,89,123,207,208,123,97,52,185,199,74,156,91,123,253,242,22,234,208,72,81,160,195,208,254,7,138,218,1,174,48,140,231,171,54,116,215,129,114,14,42,65,27,201,213,188,175,31,41,25,38,182,55,61,145,63,153,146,145,115,75,180,159,158,224,222,45,239,160,115,171,174,131,20,189,236,156,161,194,246,52,189,130,71,251,63,153,56,133,163,29,149,40,11,74,175,49,129,195,35,201,93,144,12,246,51,73,115,174,69,18,95,116,223,29,44,81,48,212,53,158,184,58,81,122,13,58,137,115,22,79,209,21,149,169,121,186,178,51,131,70,71,132,76,38,1,98,21,40,55,2,14,7,12,176,11,252,230,52,176,47,124,12,119,129,87,55,37,170,127,171,139,43,241,24,34,151,110,219,7,67,189,86,94,167,116,143,109,21,244,27,27,168,221,183,239,113,142,44,132,125,250,90,35,234,45,28,111,198,144,74,60,226,178,23,31,242,78,160,97,150,156,5,14,27,113,81,107,48,107,27,211,48,251,238,121,219,220,186,96,104,155,41,121,211,49,11,63,239,177,91,188,219,130,4,231,55,180,166,90,62,24,90,37,111,250,206,47,204,243,30,172,241,143,118,133,63,122,66,18,92,205,223,63,32,199,236,236,5,216,241,88,8,134,47,207,210,81,58,8,112,9,74,209,77,135,169,125,120,168,59,238,74,189,117,192,49,155,76,81,172,189,60,150,214,148,236,31,171,126,223,255,103,165,203,146,127,165,149,25,60,38,215,15,213,178,211,113,4,222,77,51,14,107,213,124,13,217,78,253,143,13,60,248,173,244,167,225,33,158,225,223,79,234,45,192,61,35,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb44dd42-c00a-4af9-8f21-866dc391cd62"));
		}

		#endregion

	}

	#endregion

}
