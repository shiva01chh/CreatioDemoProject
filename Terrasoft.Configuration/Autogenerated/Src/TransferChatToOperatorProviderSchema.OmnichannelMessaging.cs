﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TransferChatToOperatorProviderSchema

	/// <exclude/>
	public class TransferChatToOperatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TransferChatToOperatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TransferChatToOperatorProviderSchema(TransferChatToOperatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c");
			Name = "TransferChatToOperatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,87,89,79,35,57,16,126,14,210,252,7,171,119,31,58,82,212,209,188,66,200,136,9,44,66,226,24,13,97,247,113,228,184,43,193,187,221,118,214,118,7,50,81,254,251,150,175,190,18,24,164,125,65,105,187,234,171,227,171,195,8,90,130,94,83,6,100,14,74,81,45,151,38,155,73,177,228,171,74,81,195,165,248,116,178,251,116,50,168,52,23,43,242,184,213,6,202,179,222,55,202,23,5,48,43,172,179,107,16,160,56,59,144,185,229,226,223,230,176,109,171,44,165,56,126,211,242,34,123,40,5,103,207,84,8,40,178,59,208,154,174,80,250,184,154,2,60,199,155,241,120,76,38,186,42,75,170,182,211,240,253,29,214,10,52,8,163,201,178,18,206,103,90,112,179,37,114,73,140,162,66,47,17,200,2,162,45,67,140,36,114,13,232,129,84,89,4,28,183,16,215,213,162,224,140,176,130,106,77,230,65,125,134,154,115,249,16,244,190,41,185,225,57,40,114,74,190,82,13,238,50,8,198,43,4,218,57,135,7,191,41,88,161,71,4,111,80,221,112,208,167,248,155,111,168,1,47,176,246,31,196,194,68,11,51,202,158,129,252,96,253,163,179,247,21,186,95,231,211,35,8,228,203,23,146,30,57,62,39,2,94,14,33,211,39,141,209,75,164,200,229,117,56,60,11,81,129,200,125,96,221,40,239,192,60,203,252,173,16,181,113,60,92,131,185,101,63,231,240,106,60,235,144,94,87,60,119,244,220,228,35,226,62,208,155,153,251,30,18,91,171,131,65,26,148,35,121,247,88,228,163,136,152,115,133,14,66,254,208,186,28,98,76,173,10,179,104,145,29,172,232,58,204,11,145,95,30,209,254,186,245,230,211,232,85,227,144,35,97,160,192,84,74,4,7,178,63,164,42,169,73,109,14,111,37,195,242,251,73,23,5,60,186,203,94,14,179,191,164,250,199,181,103,246,29,180,172,20,67,57,169,48,13,35,146,188,95,112,201,200,153,30,36,7,54,116,214,174,66,5,121,163,156,253,73,139,10,146,225,168,151,186,163,57,115,177,237,187,172,109,36,242,17,161,27,92,79,90,196,172,137,99,29,214,2,63,166,113,204,39,17,185,241,130,217,92,134,44,133,188,118,202,47,123,90,231,232,194,5,38,110,227,250,76,207,100,37,76,218,182,250,57,40,222,75,195,151,28,201,189,135,151,121,215,158,187,218,118,180,88,155,203,182,234,147,80,64,243,80,152,65,209,209,202,181,153,216,8,167,100,215,138,154,236,71,135,209,5,216,13,85,164,244,64,239,215,162,253,14,22,117,40,184,97,118,75,181,121,80,151,176,164,85,97,210,35,158,98,73,109,64,105,55,75,255,159,191,163,232,102,223,138,79,70,147,248,143,224,119,106,232,173,57,129,190,99,105,84,12,117,236,176,112,51,215,75,244,39,188,59,184,17,220,112,91,241,160,221,156,226,168,77,5,46,56,28,241,19,13,64,152,130,229,249,175,186,103,92,227,117,38,190,63,89,83,69,75,34,176,9,206,147,170,211,176,201,212,54,48,97,77,7,79,198,78,250,184,114,72,101,50,13,156,16,92,149,235,194,54,18,174,158,5,16,183,96,244,51,228,29,152,176,118,222,143,160,55,73,72,215,207,17,169,151,104,52,29,105,197,77,181,192,77,149,246,21,234,251,221,7,56,107,102,251,175,232,138,81,232,163,43,247,35,12,52,5,149,76,111,114,220,237,174,30,45,221,150,254,26,237,128,8,63,149,245,20,39,43,118,141,149,247,30,180,159,1,84,184,245,226,111,120,13,142,96,81,187,69,72,186,144,178,240,163,109,88,199,213,31,125,113,218,217,134,103,178,168,74,161,195,66,189,228,254,61,162,182,19,63,10,113,10,47,254,198,244,79,131,202,96,71,146,135,38,216,81,183,85,107,145,39,177,86,146,33,91,144,223,233,149,235,69,148,253,220,22,121,52,212,84,218,97,180,70,77,93,18,174,227,116,118,35,176,152,86,248,94,210,182,196,188,14,217,59,144,189,111,254,238,250,197,56,236,15,124,99,73,205,209,173,109,54,195,145,96,112,24,243,194,13,134,52,142,144,16,120,24,33,124,73,210,22,200,185,203,96,118,85,174,205,54,102,43,174,208,116,73,11,13,135,27,214,123,101,212,54,202,135,101,210,140,212,195,135,196,236,141,109,237,168,209,238,217,122,215,86,127,108,31,165,221,41,56,232,5,126,145,199,181,144,118,144,144,179,202,144,31,81,235,142,10,60,84,86,188,139,222,81,122,195,198,172,144,26,230,173,106,237,164,248,32,170,71,191,59,190,41,216,112,120,105,18,222,31,232,131,35,235,187,189,13,15,128,219,123,166,19,69,216,0,189,39,205,172,194,101,34,140,61,205,44,94,244,34,236,182,247,242,16,201,38,140,26,246,76,210,171,87,6,107,55,221,224,181,174,148,91,185,202,174,148,66,175,127,79,46,240,198,254,36,146,49,107,54,39,47,88,139,208,237,113,107,149,236,188,27,123,59,128,98,216,100,215,196,189,207,136,3,37,59,120,13,255,128,192,62,137,41,248,80,117,90,199,46,97,81,173,208,49,123,125,218,24,125,161,186,189,105,223,118,34,233,190,40,83,220,139,135,246,142,207,102,119,234,254,156,156,252,7,69,17,85,67,246,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChatTransferredToOperatorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChatTransferredToOperatorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("82850838-c01b-d332-95bd-3af1d1a36883"),
				Name = "ChatTransferredToOperator",
				CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988"),
				CreatedInSchemaUId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c"),
				ModifiedInSchemaUId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c"));
		}

		#endregion

	}

	#endregion

}

