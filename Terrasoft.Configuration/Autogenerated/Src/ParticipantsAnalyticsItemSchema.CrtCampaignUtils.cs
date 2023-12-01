namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsItemSchema

	/// <exclude/>
	public class ParticipantsAnalyticsItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsItemSchema(ParticipantsAnalyticsItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f63154a0-be3b-4482-959d-f99cde09a649");
			Name = "ParticipantsAnalyticsItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,148,77,111,219,48,12,134,207,41,208,255,64,164,135,109,23,251,190,182,3,6,119,216,122,88,17,44,189,13,59,40,50,237,16,176,62,38,74,24,178,98,255,125,148,189,4,110,211,24,241,105,57,56,32,253,138,124,31,81,150,85,6,217,43,141,240,136,33,40,118,77,44,42,103,27,106,83,80,145,156,189,188,120,186,188,88,36,38,219,194,122,199,17,205,245,139,184,248,150,108,36,131,197,26,3,169,142,126,247,235,68,37,186,171,128,173,4,80,117,138,249,61,172,84,136,164,201,43,27,249,163,85,221,78,34,190,151,26,189,184,44,75,184,225,100,140,10,187,15,255,226,59,100,29,104,131,12,54,25,169,175,85,7,100,107,249,143,46,48,52,46,72,40,5,224,23,197,173,172,70,4,29,176,185,93,230,170,247,245,178,220,23,186,41,71,149,191,223,169,168,4,51,6,165,227,15,73,248,180,233,72,131,206,54,167,92,46,158,122,167,7,174,85,112,30,69,141,25,174,175,49,188,127,137,210,39,42,101,188,162,214,2,101,195,84,163,108,91,67,24,138,195,138,177,199,193,228,87,52,27,12,111,31,100,76,112,11,75,26,168,222,101,207,123,211,159,19,213,48,224,66,158,213,98,209,98,188,6,150,71,142,254,76,56,26,147,130,118,50,199,163,125,220,155,30,73,139,117,68,95,57,227,59,140,152,183,24,136,1,127,38,25,77,12,9,103,224,232,125,145,177,145,42,251,120,142,40,35,134,234,164,246,191,83,55,170,227,57,216,214,217,211,52,199,228,15,83,242,9,248,215,90,203,71,238,194,25,61,63,189,170,155,217,204,7,167,145,243,85,113,70,199,213,105,241,204,182,156,216,163,173,207,218,219,245,73,237,220,83,245,232,162,28,5,127,124,182,154,224,12,196,45,30,190,255,55,12,157,107,103,156,151,45,177,220,118,187,51,112,190,156,80,78,192,92,9,254,112,155,245,241,144,125,158,148,156,252,254,2,2,97,82,185,43,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f63154a0-be3b-4482-959d-f99cde09a649"));
		}

		#endregion

	}

	#endregion

}

