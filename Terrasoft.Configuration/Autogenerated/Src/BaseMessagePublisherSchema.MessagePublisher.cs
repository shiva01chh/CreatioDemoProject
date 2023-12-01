﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessagePublisherSchema

	/// <exclude/>
	public class BaseMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessagePublisherSchema(BaseMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab");
			Name = "BaseMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,219,106,219,64,16,125,150,193,255,48,77,95,20,48,242,123,156,164,52,113,18,76,73,9,117,218,215,178,145,70,246,130,180,18,123,113,17,33,255,222,217,139,28,73,150,82,106,140,173,157,157,61,115,102,230,140,214,40,46,118,176,109,148,198,114,53,159,153,206,50,185,173,138,2,83,205,43,161,146,7,20,40,121,122,116,121,70,41,153,170,114,77,94,18,39,204,201,157,208,92,115,84,180,63,159,9,86,162,170,89,138,61,47,145,243,157,145,204,70,153,207,94,231,179,136,190,159,37,238,104,13,183,5,83,234,2,110,152,194,71,84,138,237,240,201,188,20,92,237,81,90,192,168,182,171,20,216,139,210,146,165,26,82,235,63,234,14,23,176,57,133,136,94,29,204,49,222,61,199,34,163,128,79,146,31,152,70,191,185,92,46,225,82,153,178,100,178,185,110,13,107,238,234,66,38,168,114,112,153,1,19,25,28,88,97,232,145,108,185,195,74,142,8,203,46,68,237,3,128,68,150,85,162,104,186,120,151,148,12,149,114,1,254,255,26,126,163,173,98,227,201,173,153,102,171,192,26,69,230,137,79,101,81,105,106,31,102,126,187,110,151,1,24,92,115,154,109,186,199,146,125,167,12,224,42,236,36,119,101,173,155,149,61,212,63,120,164,251,83,161,164,214,9,175,142,193,242,31,244,136,86,141,210,170,226,3,138,15,134,103,129,224,15,76,43,153,109,50,120,133,29,234,21,40,251,243,214,146,155,138,66,116,40,25,147,234,74,126,16,102,76,42,241,32,57,211,91,46,58,173,58,233,212,176,81,231,96,5,29,69,3,196,171,1,166,171,116,116,210,102,242,27,233,60,121,14,234,114,5,15,168,73,178,37,211,13,141,172,41,197,47,171,194,248,220,121,191,157,118,35,84,46,84,234,17,245,190,234,169,190,109,187,215,168,107,197,68,4,159,94,208,83,109,29,100,215,129,168,9,83,20,19,249,37,207,178,33,92,15,117,182,201,206,22,80,25,61,2,227,19,137,36,106,35,197,104,24,31,7,190,56,178,94,190,52,241,2,255,56,67,60,5,57,170,162,201,234,76,104,200,119,195,86,200,63,197,109,215,15,76,130,114,211,69,117,232,75,32,233,206,222,35,19,164,63,73,175,88,189,33,209,50,145,226,77,99,7,50,30,78,104,40,132,5,246,197,180,35,235,118,147,91,154,77,141,129,65,63,88,56,229,79,36,180,247,53,43,185,248,193,119,123,173,8,32,103,133,66,239,194,115,136,63,5,191,123,212,233,254,94,86,229,250,38,238,11,238,188,77,48,250,127,18,45,139,45,234,53,230,157,134,168,32,87,223,147,73,178,52,210,129,107,78,247,11,75,247,16,191,87,195,73,203,77,14,23,167,111,205,1,107,75,161,171,229,1,68,242,13,155,197,16,55,233,202,241,173,43,74,239,56,53,112,227,130,114,151,87,80,147,191,200,14,92,106,195,10,56,84,52,114,225,133,212,147,211,177,224,29,181,245,186,187,101,135,15,6,159,214,222,58,48,182,220,54,66,163,204,233,134,30,189,45,223,47,92,222,250,77,93,170,196,182,151,194,106,34,50,217,232,243,23,97,75,162,227,132,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab"));
		}

		#endregion

	}

	#endregion

}
