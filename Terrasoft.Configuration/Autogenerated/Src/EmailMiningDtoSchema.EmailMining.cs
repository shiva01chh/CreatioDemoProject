﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningDtoSchema

	/// <exclude/>
	public class EmailMiningDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningDtoSchema(EmailMiningDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29f92a94-b37b-4607-870b-dad0d31644fd");
			Name = "EmailMiningDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d3b16cd4-e124-46c1-8f09-d3b70a775b3e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,221,111,211,48,16,127,46,210,254,135,163,123,96,72,35,149,128,7,24,109,37,216,6,26,168,219,212,86,123,153,120,112,147,75,107,145,216,193,231,172,20,196,255,206,217,73,250,181,118,164,29,244,165,182,115,31,191,59,223,253,206,74,164,72,153,8,17,134,104,140,32,29,219,224,84,171,88,142,115,35,172,212,42,56,79,133,76,122,82,73,53,62,120,242,235,224,73,35,39,94,194,96,70,22,211,160,159,43,43,83,12,6,104,164,72,228,79,175,243,110,46,181,48,122,174,140,12,39,41,42,27,92,40,139,38,102,159,180,16,188,196,169,213,202,75,126,38,111,129,63,29,26,28,179,57,56,77,4,209,9,124,66,235,193,156,179,75,43,145,250,248,61,71,178,94,180,213,106,65,155,242,52,21,102,214,45,247,125,204,12,18,123,36,32,52,119,146,131,52,133,10,196,218,0,133,70,100,206,55,58,163,96,241,135,5,169,172,6,178,38,15,109,110,48,130,72,88,17,148,230,134,87,103,87,112,120,218,239,189,120,249,246,213,235,55,39,206,126,226,50,55,149,118,2,237,176,187,49,196,160,68,73,193,22,248,237,86,216,173,92,180,91,75,33,220,158,177,115,190,11,107,68,104,191,242,65,150,143,18,25,66,232,178,177,61,25,141,95,62,33,243,228,93,27,157,161,113,34,39,112,237,45,20,223,215,51,230,15,188,73,24,233,104,6,156,136,76,24,194,96,46,188,12,174,64,215,195,116,132,230,232,146,139,8,58,208,244,137,252,192,202,205,99,184,240,136,164,75,98,7,56,161,248,220,133,80,197,192,41,118,153,63,175,20,192,21,86,163,49,70,251,206,47,168,92,252,174,135,149,175,51,21,246,4,248,62,20,30,195,196,166,201,14,176,83,26,15,103,25,214,5,221,43,196,247,129,124,149,185,246,16,9,215,163,138,208,148,149,39,162,136,235,148,118,64,92,168,251,4,172,163,142,69,66,27,97,15,22,58,251,64,231,122,35,112,93,227,254,237,4,225,253,245,5,124,195,217,14,168,89,186,110,142,223,103,242,11,254,173,42,14,57,162,162,200,253,190,56,93,59,252,43,133,80,198,180,131,117,56,196,148,178,174,51,214,184,99,138,163,146,97,30,77,22,133,143,77,108,81,124,249,103,116,81,5,254,40,190,184,87,21,88,218,231,141,176,144,74,197,215,28,27,157,22,31,29,130,103,84,242,11,243,237,150,226,241,39,119,34,201,113,190,29,178,186,103,232,202,193,146,234,66,114,83,213,57,173,42,234,102,81,107,183,110,196,148,113,206,142,170,197,3,10,101,42,135,75,95,86,55,123,52,212,13,79,204,216,233,202,120,149,14,34,205,127,10,70,152,104,53,38,207,195,133,123,173,150,195,102,114,22,221,225,68,18,100,101,0,192,107,110,45,166,23,214,137,48,22,121,98,193,39,199,21,156,39,6,87,61,199,149,137,117,199,83,65,160,180,5,202,48,116,208,34,30,135,213,196,12,218,45,239,176,126,183,75,90,98,156,51,31,211,71,131,247,88,214,195,58,102,50,151,246,172,128,124,227,17,175,48,217,195,23,182,221,211,146,159,106,25,148,94,86,46,118,164,117,194,176,54,154,217,147,44,231,93,193,47,32,94,242,43,139,196,120,151,97,90,106,60,192,239,15,103,101,161,95,55,11,213,80,118,128,123,133,246,163,39,197,156,52,201,10,155,19,132,58,218,37,9,78,124,239,12,148,202,117,195,231,183,31,156,178,202,62,49,247,145,223,139,138,92,159,185,145,230,218,204,181,151,35,189,54,113,13,133,6,227,78,115,153,50,154,173,238,74,227,186,198,99,109,149,39,137,111,210,149,150,5,205,150,204,84,110,125,141,173,214,241,71,46,96,126,190,46,2,41,87,13,227,97,174,82,87,167,3,206,105,17,235,239,255,31,232,191,10,114,144,135,60,49,169,94,144,79,183,5,89,227,13,225,207,248,247,7,83,205,6,37,43,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29f92a94-b37b-4607-870b-dad0d31644fd"));
		}

		#endregion

	}

	#endregion

}

