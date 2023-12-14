﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseRecordsOperationWorkerSchema

	/// <exclude/>
	public class BaseRecordsOperationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseRecordsOperationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseRecordsOperationWorkerSchema(BaseRecordsOperationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5");
			Name = "BaseRecordsOperationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,223,111,219,54,16,126,214,128,253,15,156,247,34,3,134,176,231,36,14,144,38,78,102,160,89,219,56,91,31,186,162,160,165,139,205,141,38,29,146,114,99,20,249,223,119,20,169,95,148,233,120,65,144,72,228,241,238,190,187,239,142,39,65,55,160,183,52,7,242,8,74,81,45,159,76,118,45,197,19,91,149,138,26,38,5,249,241,243,79,73,169,153,88,145,197,94,27,216,156,7,239,217,123,38,158,7,139,215,146,115,200,173,2,157,221,129,0,197,242,86,166,107,74,65,108,61,155,9,195,12,3,125,88,96,179,145,162,221,89,113,185,164,252,236,204,173,103,239,229,106,133,203,184,143,18,191,42,88,89,36,215,156,106,125,70,222,81,13,15,144,75,85,232,15,91,112,40,63,75,245,47,168,74,122,91,46,57,203,9,93,106,163,104,110,72,110,79,29,57,68,206,200,60,178,243,163,82,216,216,191,101,192,11,116,224,163,98,59,106,192,109,110,221,11,209,6,79,230,68,1,45,164,224,123,50,71,8,228,27,199,63,83,130,143,247,84,208,21,40,140,165,177,216,64,165,163,251,146,27,118,3,28,12,140,198,231,222,20,136,194,89,139,153,150,6,211,2,69,109,220,191,182,118,255,212,160,144,0,194,37,47,120,61,143,28,154,223,176,106,159,170,253,5,134,13,35,63,33,114,249,15,74,93,146,143,84,33,199,12,40,29,156,246,81,107,130,54,123,129,188,52,82,145,193,202,27,224,208,63,52,90,230,40,121,12,98,60,133,105,0,186,236,189,78,172,154,36,57,134,113,219,96,28,87,245,146,36,129,198,105,160,179,10,69,210,134,6,5,182,253,56,189,30,199,140,40,17,131,173,142,3,136,29,163,170,242,217,47,242,53,108,232,167,18,212,158,124,3,253,28,36,97,40,52,211,207,30,195,10,140,127,74,216,19,73,237,105,50,157,18,81,114,94,195,76,18,23,10,162,43,13,127,32,2,132,210,226,250,50,90,52,27,163,175,217,163,92,84,226,233,248,220,31,119,74,137,128,239,67,87,130,180,100,93,1,95,15,147,142,225,158,206,236,170,40,174,56,119,194,216,140,202,141,208,141,213,87,247,79,129,41,149,104,163,226,214,223,8,252,61,152,181,140,86,177,227,23,38,36,7,173,161,152,237,64,152,43,181,210,4,235,54,182,151,222,149,204,214,146,221,157,23,117,100,103,47,57,108,43,238,192,11,6,8,207,119,202,194,111,213,128,22,116,7,216,21,82,120,153,180,122,220,150,199,104,227,27,181,223,36,243,193,159,69,123,181,26,79,254,214,155,41,250,227,130,213,165,105,141,127,39,17,74,237,78,23,194,132,28,68,105,121,133,248,126,9,88,101,251,94,54,83,74,170,212,17,198,222,73,57,53,105,125,190,195,164,9,106,207,238,17,18,242,161,122,241,200,95,9,112,13,61,141,115,241,36,79,81,56,210,101,110,131,244,183,24,141,199,67,106,244,192,62,192,70,238,160,141,106,197,209,212,253,107,47,65,2,193,194,196,211,221,111,244,226,225,54,194,152,132,26,50,103,217,139,31,113,211,27,66,6,221,50,165,205,169,30,14,93,234,216,190,150,165,48,228,146,252,214,184,231,137,54,144,172,108,166,7,115,82,115,19,81,190,17,228,171,237,150,239,3,254,30,46,155,104,1,170,216,198,244,104,109,6,229,244,65,132,94,152,53,211,147,168,246,113,180,72,26,217,91,169,174,184,189,73,247,238,46,47,252,29,149,206,103,162,220,96,201,47,57,92,88,172,151,36,111,233,227,203,242,212,36,238,168,26,236,89,157,22,254,208,208,120,144,197,5,216,167,148,225,104,71,166,151,164,138,253,216,190,101,216,6,55,120,37,186,22,251,23,229,101,221,135,135,238,67,213,15,160,232,248,59,237,96,202,92,191,24,144,173,242,211,43,125,194,185,144,230,107,231,0,177,191,226,128,218,134,148,7,121,195,138,160,88,146,100,144,157,27,166,13,19,185,9,3,124,122,217,56,193,47,95,157,0,222,211,182,115,134,97,125,148,87,56,208,238,211,3,33,115,231,47,73,225,61,121,0,141,243,158,147,235,175,213,138,209,70,118,167,100,185,125,183,79,153,205,18,59,148,156,58,149,96,37,160,46,79,239,192,176,206,57,80,149,134,193,111,217,100,227,223,247,38,222,175,240,70,142,55,171,19,174,219,200,88,183,99,202,148,148,187,188,13,235,211,141,104,68,163,126,59,46,68,251,3,181,213,90,231,206,174,254,78,69,193,65,93,196,78,92,146,181,147,192,248,7,50,231,77,227,172,69,194,102,238,215,211,218,45,218,244,138,94,84,154,143,144,112,96,179,61,235,163,2,156,25,131,43,135,180,17,14,194,228,154,78,117,100,56,105,29,235,53,181,211,110,210,67,70,187,102,167,171,57,33,143,246,136,170,59,180,183,234,56,36,59,206,153,120,133,105,48,238,156,243,163,179,119,203,184,157,32,251,20,236,110,88,62,217,247,107,100,165,1,183,250,153,153,117,59,125,166,110,17,191,9,17,53,211,82,60,238,183,248,89,249,140,116,169,27,40,158,247,69,82,57,224,42,37,179,227,228,164,197,57,14,218,120,29,211,38,61,237,164,19,159,211,142,177,60,246,1,121,15,155,37,226,240,118,221,135,41,88,2,146,19,41,58,36,102,71,83,175,114,170,86,217,216,63,126,251,212,140,136,210,169,35,122,222,233,134,71,218,38,82,201,230,2,195,55,104,185,253,175,0,175,48,218,160,7,253,216,127,106,189,121,221,118,46,215,97,83,239,162,168,91,223,52,28,169,34,167,190,175,25,135,55,198,58,167,44,168,232,94,179,76,6,95,197,153,123,8,38,192,195,119,158,19,137,95,214,201,225,49,118,56,181,246,109,253,207,72,28,105,248,110,181,191,88,173,217,159,255,0,201,164,220,85,165,18,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54fcb780-2ca1-4811-a181-edfffeacf325"),
				Name = "SuccessMessage",
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f"),
				CreatedInSchemaUId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5"),
				ModifiedInSchemaUId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5"));
		}

		#endregion

	}

	#endregion

}

