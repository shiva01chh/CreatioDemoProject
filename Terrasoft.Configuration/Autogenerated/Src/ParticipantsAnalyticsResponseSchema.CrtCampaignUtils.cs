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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,203,78,195,64,12,60,23,137,127,176,202,133,94,146,59,143,74,168,160,170,18,32,4,220,16,7,119,227,4,75,187,155,176,15,80,65,252,59,222,164,137,218,242,18,57,68,26,123,108,143,199,107,209,144,111,80,17,220,147,115,232,235,50,100,179,218,150,92,69,135,129,107,187,191,247,190,191,55,138,158,109,5,119,43,31,200,28,239,96,225,107,77,42,145,125,54,39,75,142,213,23,206,109,180,129,13,101,119,146,69,205,111,109,111,97,9,239,192,81,37,0,102,26,189,63,130,27,116,129,21,55,104,131,63,179,168,87,130,252,173,136,148,246,212,22,228,121,14,39,62,26,131,110,53,93,227,158,0,101,237,96,224,16,129,114,84,158,142,103,104,26,228,202,202,248,23,86,148,237,226,57,133,111,231,30,254,160,230,57,146,15,147,113,62,205,214,179,196,179,128,108,61,176,21,5,166,93,15,112,89,199,0,205,70,11,64,173,107,213,101,217,2,161,122,2,181,214,2,156,140,234,181,231,27,11,62,156,99,192,52,193,161,10,143,18,104,226,82,179,2,149,28,251,203,176,209,123,107,218,96,243,141,171,27,146,10,74,94,183,125,186,252,174,171,221,90,131,182,130,228,128,37,147,203,6,242,166,196,78,227,21,153,37,185,195,107,121,84,112,10,227,126,179,69,49,158,36,217,189,238,121,228,98,104,189,40,32,189,176,209,168,162,112,12,94,126,9,125,252,34,234,146,125,128,186,220,54,206,195,235,19,39,55,251,67,108,218,254,15,205,216,59,184,72,77,183,117,47,46,108,52,228,112,169,233,228,91,215,83,205,20,182,160,255,101,187,3,178,69,119,149,22,119,209,237,160,196,228,251,4,244,107,168,77,166,3,0,0 };
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

