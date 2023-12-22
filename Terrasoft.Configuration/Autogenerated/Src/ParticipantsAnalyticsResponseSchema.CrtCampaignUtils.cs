namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsResponseSchema

	/// <exclude/>
	public class ParticipantsAnalyticsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsResponseSchema(ParticipantsAnalyticsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c");
			Name = "ParticipantsAnalyticsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,107,219,64,16,61,219,144,255,48,216,151,248,34,221,235,196,80,156,98,12,109,49,78,111,33,135,241,106,164,12,236,174,212,253,104,113,67,255,123,103,37,75,200,174,155,18,29,4,111,230,205,204,155,55,107,209,144,111,80,17,124,35,231,208,215,101,200,214,181,45,185,138,14,3,215,246,102,250,122,51,157,68,207,182,130,199,163,15,100,150,23,88,248,90,147,74,100,159,109,200,146,99,245,23,103,31,109,96,67,217,163,100,81,243,175,182,183,176,132,55,119,84,9,128,181,70,239,63,192,14,93,96,197,13,218,224,63,90,212,71,65,126,47,34,165,61,181,5,121,158,195,157,143,198,160,59,174,78,184,39,64,89,59,24,56,68,160,28,149,247,179,53,154,6,185,178,50,254,7,43,202,46,241,134,194,213,185,183,255,80,243,61,146,15,139,89,190,202,78,179,196,179,128,108,61,176,21,5,166,93,15,240,80,199,0,205,168,5,160,214,181,234,178,108,129,80,189,128,58,105,1,78,70,245,218,243,209,130,79,15,24,48,77,112,168,194,179,4,154,120,208,172,64,37,199,254,103,216,228,181,53,109,176,121,231,234,134,164,130,146,215,109,159,46,127,233,106,183,214,160,173,32,57,96,201,228,178,129,60,150,216,105,252,66,230,64,238,246,171,60,42,184,135,89,191,217,182,152,45,146,236,94,247,38,114,49,180,222,22,144,94,216,100,82,81,88,130,151,95,66,191,223,16,245,153,125,128,186,60,55,206,195,207,23,78,110,246,135,24,219,254,14,205,216,59,184,77,77,207,117,111,63,217,104,200,225,65,211,221,85,215,83,205,10,206,160,127,99,187,57,217,162,187,74,139,187,232,121,80,98,227,239,15,151,40,181,84,175,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c"));
		}

		#endregion

	}

	#endregion

}

