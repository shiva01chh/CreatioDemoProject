﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailCampaignElementSchema

	/// <exclude/>
	public class BulkEmailCampaignElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailCampaignElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailCampaignElementSchema(BulkEmailCampaignElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("402d2d85-b8dd-404b-8907-27c21ffc4498");
			Name = "BulkEmailCampaignElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,75,115,219,56,18,62,107,170,230,63,96,181,115,160,106,93,116,230,234,87,202,113,148,172,166,28,59,107,217,155,195,214,86,10,34,33,153,27,138,96,0,208,143,114,249,191,111,227,69,2,36,72,81,169,201,97,230,48,142,128,70,163,251,67,63,65,20,120,75,120,137,19,130,110,9,99,152,211,181,136,47,104,177,206,54,21,195,34,163,197,175,191,188,252,250,203,164,226,89,177,65,203,103,46,200,246,184,245,27,232,243,156,36,146,152,199,31,73,65,88,150,116,104,222,99,129,155,65,119,175,237,150,22,225,25,70,226,11,188,45,113,182,233,39,120,255,174,119,234,51,163,9,225,188,153,223,228,116,133,243,163,35,189,103,124,73,55,27,24,110,230,229,42,187,33,96,192,5,71,167,200,19,35,246,166,113,33,36,119,88,255,119,70,54,160,62,186,200,49,231,71,232,93,149,127,155,111,113,150,91,242,121,78,182,164,16,138,246,240,240,16,157,240,106,187,197,236,249,204,252,158,63,145,164,18,120,149,19,180,130,181,136,200,197,136,232,85,40,43,80,98,5,176,12,14,29,14,101,181,202,179,4,37,114,243,222,189,209,17,178,35,31,114,250,88,75,52,121,81,82,53,42,88,205,142,208,103,150,61,96,65,244,124,169,127,160,68,206,35,46,152,68,236,61,89,227,42,23,231,85,154,145,34,33,203,228,30,36,191,2,147,2,224,166,192,73,224,68,76,143,123,151,91,129,62,99,38,178,36,43,97,91,37,250,45,102,27,34,110,37,30,53,179,109,9,116,76,36,165,71,243,195,204,175,203,49,236,175,203,233,177,129,135,20,169,70,200,135,11,140,172,36,176,1,81,120,81,1,126,64,82,77,210,62,104,53,240,145,128,85,81,134,184,252,43,238,73,125,178,40,7,115,36,44,70,11,133,63,56,36,93,195,114,2,20,140,172,79,167,11,48,215,233,225,89,92,115,118,45,160,70,64,82,161,175,154,149,129,198,200,164,167,46,213,12,146,46,61,153,128,130,232,244,204,146,163,183,111,81,100,255,125,42,41,63,225,2,75,145,64,102,189,46,234,122,72,237,17,154,66,226,57,155,169,157,39,220,103,127,138,30,112,94,17,53,247,58,128,208,146,176,7,194,209,197,205,221,123,36,177,85,81,136,163,53,128,134,141,157,73,104,36,118,141,175,236,128,165,118,10,107,169,55,164,164,60,19,148,61,163,175,171,254,73,13,161,118,175,33,30,67,115,62,214,3,155,201,3,40,200,227,16,179,232,142,19,6,192,23,58,220,182,128,30,226,61,22,253,243,2,194,77,208,0,107,177,62,224,4,167,4,108,81,71,156,177,208,235,101,142,148,122,32,8,177,161,109,255,238,129,210,204,42,251,109,15,158,250,144,234,209,54,140,125,56,214,60,198,97,167,130,137,49,77,29,193,107,131,229,42,50,238,128,202,4,174,175,184,19,78,93,144,12,85,32,230,250,240,116,185,104,132,2,227,167,50,44,117,25,70,109,96,130,75,59,216,140,10,149,74,151,1,44,239,138,236,123,69,80,150,66,146,202,214,25,196,15,0,118,183,191,107,136,62,86,89,218,156,249,34,69,47,8,80,57,150,65,247,24,189,250,249,76,209,126,229,80,40,128,140,119,139,244,120,63,145,228,6,242,56,12,131,17,114,45,235,173,90,7,214,200,16,47,248,124,91,138,231,104,134,228,137,53,19,242,164,128,71,124,69,30,229,95,56,32,72,235,109,225,39,89,33,8,43,112,142,120,135,243,62,231,245,137,136,123,154,246,213,1,198,12,123,12,199,168,246,128,101,166,147,197,161,113,196,165,250,209,23,198,228,156,250,231,68,214,148,213,182,136,166,156,79,15,208,84,50,157,206,226,115,30,77,155,93,166,51,67,251,129,209,109,212,196,39,67,184,106,8,22,176,19,251,131,102,133,67,229,75,93,175,193,220,174,154,196,215,133,25,65,32,194,34,5,26,56,151,239,21,206,21,115,24,243,121,72,138,238,134,80,255,122,91,128,66,51,197,89,107,118,215,230,139,213,240,28,76,76,60,95,175,254,7,136,56,124,191,220,19,70,236,238,222,74,141,87,12,197,14,32,3,199,31,57,230,63,243,0,142,151,37,73,178,245,243,21,189,164,201,183,127,130,177,240,200,16,168,227,114,125,219,172,208,229,41,168,137,115,204,78,244,201,159,217,69,140,136,138,21,198,30,64,158,171,42,207,175,217,151,251,12,22,200,198,34,106,56,74,115,238,47,25,143,156,189,93,251,236,90,220,200,186,17,204,16,172,223,248,27,120,149,66,138,71,169,150,32,146,30,52,51,200,190,29,91,139,106,242,163,241,213,229,177,175,132,118,0,169,196,252,41,131,206,40,117,86,25,231,48,122,146,214,238,214,167,12,222,253,222,228,123,80,199,48,126,159,121,126,211,217,70,89,105,82,18,65,203,182,221,153,81,176,61,40,13,83,150,229,249,13,152,82,9,7,41,58,118,44,92,50,57,137,48,55,2,135,14,183,193,165,89,115,75,3,40,47,210,27,146,171,154,208,104,111,86,214,185,73,253,220,21,128,90,212,158,127,104,196,160,178,205,9,102,209,80,112,10,104,217,2,191,43,191,2,217,120,111,152,157,227,185,131,17,204,116,64,54,114,9,19,87,12,23,211,125,249,65,162,95,28,135,220,108,121,94,164,97,145,70,198,156,33,54,55,132,151,80,212,147,97,118,159,116,110,53,141,70,103,241,13,193,233,243,45,93,66,250,114,246,115,144,178,234,46,4,217,26,152,146,204,160,4,255,232,132,208,1,116,28,78,109,136,52,39,112,4,202,210,160,19,120,224,53,129,54,169,24,233,198,24,93,139,141,14,112,13,59,34,195,9,160,213,137,39,154,99,111,180,9,139,97,24,103,107,20,213,94,81,164,153,116,187,166,56,177,78,102,29,71,71,137,89,124,69,5,252,95,237,200,163,94,185,204,22,175,136,228,220,214,174,74,147,71,201,166,222,142,55,105,168,17,225,34,167,5,249,84,235,63,9,16,56,190,235,203,215,98,63,83,167,184,175,208,53,58,127,235,75,47,13,58,82,39,40,124,121,166,238,85,246,61,159,145,166,208,82,53,160,211,128,8,158,86,59,171,4,155,240,123,99,57,16,67,156,21,142,196,124,206,24,101,75,129,69,197,195,1,251,0,205,159,18,82,202,35,1,83,182,216,137,186,127,182,187,182,248,26,150,109,94,157,107,186,56,4,99,35,19,196,15,107,141,9,22,201,61,138,28,105,234,131,20,247,140,62,170,44,114,190,217,64,145,12,186,214,100,145,28,190,4,124,79,234,161,51,104,59,200,211,1,34,232,213,5,184,5,214,3,133,158,224,60,77,235,76,202,155,180,231,28,148,69,141,213,100,221,68,39,156,27,173,31,11,34,208,250,67,135,182,116,19,230,194,25,234,169,52,22,133,160,81,189,185,29,133,147,138,194,117,130,19,80,189,196,222,151,252,100,157,98,4,232,168,111,59,158,70,72,91,173,26,189,90,112,47,230,69,181,37,76,10,123,34,11,192,51,183,131,49,73,176,199,68,127,82,77,81,167,127,39,5,7,28,205,170,213,200,31,49,89,222,170,235,57,205,226,223,178,179,211,90,121,220,246,7,66,181,31,208,168,255,41,64,116,18,115,232,240,139,53,213,137,199,105,190,134,232,122,109,104,84,62,223,217,170,185,45,96,51,220,233,215,118,72,24,238,226,76,221,224,177,53,13,110,111,41,212,109,151,102,237,130,122,15,83,219,129,140,170,148,70,21,179,174,178,151,89,241,13,18,152,82,185,230,210,30,220,209,155,188,153,233,101,159,89,70,25,44,153,142,237,92,101,42,110,50,49,52,161,84,180,139,20,29,223,214,116,57,214,98,131,181,100,75,121,163,102,153,249,38,83,102,253,65,110,175,130,179,181,52,32,88,215,104,119,90,173,17,175,199,58,127,150,121,78,26,240,195,54,218,37,216,211,80,155,78,74,43,184,135,69,14,182,203,65,147,116,165,237,183,75,107,185,119,133,172,17,154,37,94,197,165,202,119,37,80,200,54,7,187,251,233,53,164,4,246,175,138,176,231,144,198,110,163,191,139,101,195,83,89,215,14,158,53,181,100,251,37,43,82,250,168,86,124,168,10,197,52,178,214,36,231,111,232,227,85,181,93,25,166,53,201,236,192,37,82,115,154,233,252,169,100,218,153,219,194,72,1,246,95,213,156,157,57,76,45,80,163,139,2,72,31,149,49,170,102,189,89,226,0,221,186,21,241,143,192,178,238,119,150,223,187,190,97,50,189,107,4,251,230,251,246,49,5,147,254,138,210,28,193,233,155,226,192,119,219,168,117,195,20,250,170,123,218,127,127,215,215,9,64,109,235,86,236,183,212,187,126,221,93,97,16,163,146,108,4,251,69,183,215,120,161,106,46,24,221,143,130,245,78,176,134,83,221,58,173,10,233,152,3,31,231,226,197,182,164,76,212,188,106,193,15,220,111,17,7,206,7,0,39,121,105,254,103,232,141,151,175,234,114,215,109,21,247,189,32,11,234,52,25,209,114,180,118,247,98,150,177,17,37,118,232,228,85,91,3,6,154,165,240,171,239,176,149,211,88,133,37,10,253,231,59,243,251,192,118,248,44,253,180,188,127,28,29,138,156,35,234,213,191,112,25,217,81,32,64,36,21,232,14,119,190,138,244,128,168,227,228,143,85,243,117,197,51,174,168,111,7,214,160,93,252,188,58,114,71,98,237,75,165,250,3,214,248,18,243,175,80,254,117,101,253,179,237,170,78,192,131,213,118,173,214,143,87,221,157,74,118,95,171,234,89,176,179,40,28,106,174,117,236,244,218,163,208,165,95,104,227,64,90,27,184,174,227,230,78,77,202,208,92,119,205,6,115,151,126,12,20,43,54,209,111,83,249,248,79,61,224,121,81,164,175,205,163,39,71,62,142,82,74,56,42,168,64,91,117,7,247,152,137,123,200,128,223,171,140,145,212,148,1,242,147,123,189,120,106,206,246,31,232,183,169,125,43,167,242,23,250,207,139,127,99,255,250,223,24,221,178,76,189,67,34,134,194,201,201,48,61,13,92,209,141,248,48,190,251,193,151,41,227,184,188,239,151,55,237,104,157,211,199,250,105,223,154,218,83,6,21,237,209,246,60,34,80,35,165,116,58,84,128,151,156,78,61,83,152,158,169,63,138,99,6,74,55,111,79,4,69,43,130,74,253,26,146,164,241,201,161,98,98,158,158,216,231,97,244,129,48,150,165,230,246,54,43,54,57,177,23,105,154,113,48,105,235,135,147,145,52,165,116,165,233,41,211,133,154,19,8,227,121,193,43,70,222,191,107,134,156,128,218,44,140,193,228,152,184,101,184,224,88,83,45,56,213,181,204,37,121,32,121,44,63,249,200,215,155,153,0,145,173,115,57,151,196,166,104,226,80,160,130,16,111,12,193,164,83,135,152,66,100,22,114,38,85,26,13,85,172,195,139,235,221,193,165,164,241,129,184,101,14,81,50,221,177,206,65,65,107,232,194,224,112,87,101,151,222,196,12,134,238,172,235,27,116,143,241,13,205,243,21,78,190,5,89,15,126,205,48,31,203,27,174,147,129,136,17,84,244,64,10,101,247,106,7,8,245,23,209,68,126,140,74,221,247,174,104,183,95,219,40,160,227,192,14,47,247,164,120,53,127,213,189,190,5,179,19,5,246,247,234,177,254,155,64,169,75,158,196,244,236,86,62,24,83,28,229,225,153,97,207,79,213,90,125,248,252,76,247,210,50,20,214,78,237,5,82,88,105,73,135,124,28,175,107,15,55,79,165,245,79,253,201,85,138,96,69,113,219,177,218,190,87,152,147,216,101,98,137,155,196,96,104,79,78,157,212,96,44,248,141,155,235,90,207,243,98,249,73,215,28,164,26,142,134,251,167,174,83,244,4,112,61,236,143,170,49,248,239,255,10,163,1,40,9,47,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTriggerEmailExecutionErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTriggerEmailExecutionErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea631fc4-ceda-4f8b-97e4-158562f15a62"),
				Name = "TriggerEmailExecutionError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("402d2d85-b8dd-404b-8907-27c21ffc4498"),
				ModifiedInSchemaUId = new Guid("402d2d85-b8dd-404b-8907-27c21ffc4498")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("402d2d85-b8dd-404b-8907-27c21ffc4498"));
		}

		#endregion

	}

	#endregion

}

