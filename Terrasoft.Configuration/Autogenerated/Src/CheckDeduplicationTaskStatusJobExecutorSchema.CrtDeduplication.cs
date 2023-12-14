﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckDeduplicationTaskStatusJobExecutorSchema

	/// <exclude/>
	public class CheckDeduplicationTaskStatusJobExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckDeduplicationTaskStatusJobExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckDeduplicationTaskStatusJobExecutorSchema(CheckDeduplicationTaskStatusJobExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3603872b-6a9a-4fa0-afcd-579b143e454e");
			Name = "CheckDeduplicationTaskStatusJobExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,109,111,26,71,16,254,124,145,242,31,86,215,40,2,137,30,149,90,41,18,182,169,92,192,49,81,221,88,224,54,31,170,170,90,238,6,184,248,222,180,187,231,152,88,252,247,206,190,112,239,11,84,50,31,224,110,119,94,158,121,102,103,118,72,104,12,60,163,62,144,7,96,140,242,116,45,188,73,154,172,195,77,206,168,8,211,196,155,66,144,103,81,232,171,183,183,111,94,222,190,113,114,30,38,27,178,220,113,1,241,69,227,29,181,163,8,124,41,204,189,143,144,0,11,253,82,102,19,165,43,26,141,70,147,52,142,209,246,239,233,102,131,203,229,126,205,217,44,162,92,132,190,55,77,99,26,54,128,120,15,148,63,150,122,85,240,12,108,235,222,13,245,69,202,66,224,93,18,95,96,229,221,10,145,121,215,43,46,24,213,33,160,32,138,254,192,96,131,111,100,130,136,248,136,76,182,224,63,214,224,72,52,75,65,69,206,63,165,171,217,51,248,57,250,81,170,195,225,144,92,242,60,142,41,219,141,205,59,202,16,48,66,68,108,169,32,190,180,200,73,80,181,73,4,26,37,92,89,245,200,193,212,176,98,43,203,87,40,76,124,137,234,92,80,100,68,230,53,140,206,139,194,89,196,120,19,66,20,96,144,247,44,124,162,2,244,102,166,95,20,26,244,200,128,6,105,18,237,200,28,51,72,254,141,240,235,138,224,227,29,77,232,6,24,230,93,200,212,2,235,185,53,68,110,255,194,56,131,36,208,254,44,206,85,100,198,183,142,210,184,198,212,200,180,205,18,17,138,221,31,120,122,239,41,163,177,124,64,8,46,20,203,238,133,85,119,158,4,240,220,82,13,15,171,71,52,145,184,143,44,205,51,41,182,204,215,235,240,89,106,158,96,222,61,17,243,61,75,51,96,2,79,165,133,244,121,205,246,2,98,132,138,104,22,144,165,60,196,28,238,200,73,1,89,181,142,179,1,97,158,28,6,34,103,230,64,235,170,216,201,172,93,158,244,53,238,245,21,63,206,94,126,239,27,72,175,179,108,137,103,57,200,35,96,95,24,197,184,72,115,73,174,157,15,167,109,176,19,128,141,219,59,16,219,212,122,154,231,191,229,81,59,113,147,40,196,99,68,208,125,231,246,2,184,208,34,189,63,57,48,108,150,137,110,119,36,175,189,246,77,108,79,148,17,191,88,189,102,178,84,18,248,70,80,18,79,85,46,99,197,197,60,150,6,221,186,9,119,208,180,169,35,183,178,117,36,158,113,175,6,66,91,218,55,171,91,157,114,52,85,36,126,153,175,190,162,210,241,80,7,196,114,250,127,173,119,180,114,163,74,78,148,250,52,162,223,195,85,4,75,5,192,84,164,70,227,205,226,76,236,116,220,252,91,40,252,45,233,157,48,234,248,148,131,13,146,55,161,137,15,17,4,35,45,235,216,220,187,55,52,140,130,169,177,1,124,9,148,249,219,59,224,28,91,156,238,17,248,89,97,43,124,188,56,199,109,26,103,17,136,210,47,54,243,135,207,211,207,35,130,92,167,79,64,232,90,96,101,168,158,63,89,220,253,248,203,207,63,125,248,96,68,77,190,235,164,235,38,139,216,195,239,180,192,222,59,213,140,14,125,223,29,24,219,142,187,204,125,31,163,90,231,81,100,139,182,127,78,132,146,175,34,60,37,153,160,201,215,167,57,128,53,205,35,49,170,147,35,125,85,250,194,255,226,172,22,209,181,146,188,133,8,123,205,129,165,78,240,157,37,244,148,134,1,153,32,90,1,69,13,189,118,241,24,80,166,90,203,43,175,90,84,236,224,124,10,220,103,97,166,28,95,189,18,29,238,162,195,250,225,144,212,188,155,246,129,158,187,154,74,147,8,91,93,107,195,167,110,38,175,73,123,211,124,23,39,131,22,214,65,149,81,107,138,117,209,98,65,245,172,105,232,184,248,60,173,166,102,8,212,229,61,100,165,93,176,69,177,22,179,70,175,98,189,192,228,56,231,221,124,149,81,170,57,140,170,133,133,170,20,174,103,80,251,8,74,190,226,212,186,145,136,72,34,75,119,133,21,30,16,148,209,216,188,194,254,176,233,224,50,147,115,150,210,186,170,78,104,99,61,196,169,13,239,114,168,164,74,37,93,192,124,252,169,230,22,229,14,27,214,41,237,92,82,173,153,51,189,227,157,251,82,238,237,95,218,195,223,222,173,158,143,78,114,117,191,133,35,163,189,225,29,217,61,151,194,198,144,48,150,237,165,50,98,180,169,172,42,171,103,188,135,24,119,199,138,37,73,129,76,109,185,81,51,96,24,86,135,222,4,115,170,159,205,167,161,122,194,0,46,53,199,3,146,170,218,26,87,188,84,187,85,73,51,118,10,147,151,126,41,250,119,199,180,255,79,217,109,138,201,189,91,185,61,238,27,93,81,12,198,202,76,171,251,148,147,158,238,95,167,198,193,206,89,173,219,180,62,141,228,202,220,97,71,92,203,30,109,185,32,42,93,97,80,146,112,240,27,174,173,131,146,119,75,249,95,52,202,129,188,127,111,199,118,101,189,233,23,121,146,72,146,15,236,153,130,49,142,245,253,235,156,234,198,182,203,173,213,126,29,167,108,182,173,189,61,65,3,114,38,148,255,220,103,207,62,232,155,110,91,125,43,112,30,177,227,200,63,177,222,140,177,148,245,222,185,117,99,65,174,250,68,198,82,57,39,201,199,23,89,75,233,186,119,230,176,213,223,227,36,95,135,212,64,95,58,131,22,234,26,50,245,251,74,136,160,137,198,254,135,74,175,214,23,113,77,126,254,3,11,141,36,123,66,18,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessfullDuplicatesSearchMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessfullDuplicatesSearchMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a4daf8ec-3915-4a1a-a9fb-5256280fc27a"),
				Name = "SuccessfullDuplicatesSearchMessage",
				CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304"),
				CreatedInSchemaUId = new Guid("3603872b-6a9a-4fa0-afcd-579b143e454e"),
				ModifiedInSchemaUId = new Guid("3603872b-6a9a-4fa0-afcd-579b143e454e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3603872b-6a9a-4fa0-afcd-579b143e454e"));
		}

		#endregion

	}

	#endregion

}

