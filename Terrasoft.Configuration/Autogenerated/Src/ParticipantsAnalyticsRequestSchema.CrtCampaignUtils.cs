namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsRequestSchema

	/// <exclude/>
	public class ParticipantsAnalyticsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsRequestSchema(ParticipantsAnalyticsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80");
			Name = "ParticipantsAnalyticsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,111,219,48,12,61,167,64,255,3,145,93,218,139,115,95,63,128,34,69,63,14,27,138,166,59,13,59,48,50,237,16,144,37,87,162,55,100,197,254,251,40,59,78,226,180,107,97,96,57,4,161,248,68,190,247,68,198,97,69,177,70,67,240,68,33,96,244,133,100,115,239,10,46,155,128,194,222,29,31,189,28,31,77,154,200,174,132,197,58,10,85,103,7,113,246,216,56,225,138,178,5,5,70,203,191,219,123,138,82,220,167,64,165,6,48,183,24,227,103,120,192,32,108,184,70,39,241,202,161,93,107,20,31,233,185,161,40,45,126,54,155,193,121,108,170,10,195,250,114,19,111,242,80,99,80,178,66,1,10,31,182,88,34,48,129,138,139,233,28,171,26,185,116,202,226,39,27,202,14,227,91,146,55,219,159,188,71,234,116,58,187,204,54,189,212,22,65,118,113,71,36,38,38,96,208,154,198,162,80,212,159,93,207,4,217,214,4,236,139,246,149,206,103,123,18,191,95,163,96,170,29,208,200,15,61,168,155,165,101,3,38,89,246,129,99,147,151,214,181,173,205,15,193,215,164,23,40,121,221,150,233,242,135,182,118,122,122,178,156,147,62,96,193,157,179,240,107,197,102,53,84,224,136,242,184,19,58,84,244,90,82,167,233,11,85,75,10,39,95,213,43,184,128,105,239,205,125,62,61,77,50,123,157,183,13,231,91,46,247,57,164,113,155,76,74,146,51,136,250,149,162,63,239,168,88,136,18,133,130,109,26,140,28,215,35,24,117,151,218,2,154,165,33,173,116,242,164,83,13,55,67,212,88,126,215,13,237,216,9,141,166,167,247,63,36,183,193,140,165,118,99,177,4,89,161,0,187,156,77,59,193,77,164,253,165,58,16,175,219,160,111,159,191,70,244,44,53,63,220,136,190,87,20,20,253,183,208,145,105,103,76,86,164,115,230,45,129,206,43,251,124,132,45,202,48,73,239,250,198,161,47,75,239,45,124,27,0,254,143,41,88,18,248,98,183,223,214,151,233,57,113,28,239,59,142,226,195,58,37,223,230,189,7,248,39,239,205,198,147,203,187,165,111,227,78,209,240,80,207,246,63,127,1,174,125,20,172,234,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80"));
		}

		#endregion

	}

	#endregion

}

