﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventDataProviderSchema

	/// <exclude/>
	public class EventDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventDataProviderSchema(EventDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f78aca6a-915e-4355-bb93-f2b476e6895a");
			Name = "EventDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,223,79,219,48,16,126,46,18,255,195,41,123,73,181,42,121,135,18,9,49,168,42,109,26,106,203,51,114,157,75,235,145,216,229,236,20,24,226,127,223,217,110,89,218,108,136,60,197,247,227,187,239,62,223,89,139,6,237,70,72,132,5,18,9,107,42,151,93,25,93,169,85,75,194,41,163,179,5,9,249,160,244,234,244,228,245,244,100,208,90,254,133,249,139,117,216,156,31,157,57,177,174,81,250,44,155,77,80,35,41,217,139,249,174,244,227,95,99,183,40,33,219,217,243,133,112,197,16,112,85,11,107,207,224,122,139,218,125,19,78,220,146,217,170,18,41,4,229,121,14,99,219,54,141,160,151,98,119,222,5,128,210,149,161,38,176,135,138,76,3,132,27,67,14,44,210,86,73,204,246,233,121,39,127,211,46,107,37,65,250,154,253,146,112,6,179,128,49,143,16,135,116,6,175,129,210,59,241,27,133,117,201,204,111,73,109,133,195,232,220,196,3,72,22,135,169,56,242,237,223,87,136,229,173,112,235,121,91,85,234,25,46,32,201,197,70,229,129,64,238,157,201,249,14,27,117,25,225,15,107,93,121,56,106,165,51,228,43,134,46,98,196,177,66,193,208,9,7,83,129,136,13,103,239,241,249,113,194,120,35,72,52,160,121,76,46,146,150,21,100,4,29,239,56,41,166,12,38,52,207,14,67,221,29,248,178,113,30,18,3,206,78,219,158,170,233,97,14,28,194,15,193,231,14,6,103,176,20,22,211,99,231,43,188,125,172,204,15,116,107,83,126,70,148,25,186,150,180,245,87,227,132,116,224,118,19,15,254,2,62,171,141,69,107,185,236,180,180,73,49,143,255,192,77,106,167,42,133,100,129,71,18,86,232,34,102,87,157,30,146,169,42,139,46,41,102,40,13,149,22,226,249,227,28,105,90,221,73,9,199,126,6,197,70,139,159,203,95,44,35,11,129,60,143,132,213,69,18,238,230,134,169,117,239,103,198,47,3,207,11,38,121,1,79,107,37,215,81,33,197,82,137,186,6,205,225,88,242,114,133,154,92,109,15,127,124,231,255,195,133,9,6,95,58,189,214,109,131,36,150,53,142,39,173,42,11,207,202,239,239,254,237,97,85,71,251,157,137,114,140,120,203,93,236,147,103,33,76,202,86,16,180,84,243,18,197,93,189,227,255,175,199,43,118,30,66,35,83,152,243,232,44,204,3,106,245,155,99,140,117,51,124,108,209,186,241,135,180,139,148,171,140,184,253,167,128,21,139,15,118,180,226,33,240,218,255,247,90,97,134,151,252,236,189,248,135,118,139,228,46,235,58,237,71,101,11,19,162,210,225,8,248,101,40,224,153,45,243,160,65,58,28,6,236,183,97,104,231,223,139,16,173,93,35,91,252,247,7,115,207,98,202,243,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f78aca6a-915e-4355-bb93-f2b476e6895a"));
		}

		#endregion

	}

	#endregion

}

