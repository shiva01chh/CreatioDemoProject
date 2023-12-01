﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingExtensionsSchema

	/// <exclude/>
	public class MarketingExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingExtensionsSchema(MarketingExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db016652-cdcd-4970-851f-e074cf62fd10");
			Name = "MarketingExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("22377109-1778-4074-9bce-cc29eae9715a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,109,79,219,48,16,254,156,74,253,15,167,78,131,118,136,164,208,209,141,245,69,42,133,177,23,96,108,148,189,80,245,131,155,186,137,69,18,71,182,195,168,80,255,251,206,118,210,166,12,105,147,182,126,72,237,123,158,187,123,124,119,118,66,98,42,83,226,83,24,81,33,136,228,115,229,14,121,50,103,65,38,136,98,60,169,86,30,170,21,39,147,44,9,224,106,33,21,141,59,213,10,90,158,9,26,32,12,195,136,72,249,6,142,136,164,173,246,201,189,162,137,68,179,52,28,207,243,160,43,179,56,38,98,209,207,247,107,10,168,144,40,8,105,148,226,146,131,12,185,80,108,190,64,51,133,211,140,205,224,142,68,25,149,96,115,107,171,77,2,36,10,184,96,42,140,221,34,135,87,74,146,102,211,136,249,32,21,202,247,193,215,242,158,80,231,60,24,133,235,99,160,85,145,68,225,81,46,5,187,35,138,90,60,181,27,240,53,14,211,5,46,143,89,192,148,188,200,226,41,21,208,131,86,187,243,59,81,42,161,69,91,42,146,106,205,189,253,214,203,131,246,171,215,135,131,163,225,241,201,219,211,119,239,63,124,60,59,191,248,116,249,249,203,213,232,250,235,183,239,63,110,106,157,92,19,77,102,86,214,166,198,115,170,66,62,211,10,205,17,45,248,184,198,198,48,36,145,159,69,40,71,2,177,133,133,144,200,16,230,130,199,166,146,250,32,136,97,199,23,238,42,138,247,56,76,55,37,130,196,144,224,140,244,106,51,162,72,173,63,66,103,227,6,124,110,163,184,93,207,208,214,94,130,170,76,36,178,63,72,83,193,239,93,216,107,129,92,196,83,30,73,24,55,119,15,7,187,55,19,116,42,88,229,226,229,77,203,171,55,226,182,111,117,21,50,105,146,141,39,160,101,52,64,207,164,227,100,17,71,26,75,212,49,26,177,202,77,211,9,103,206,5,212,209,10,204,216,240,175,107,220,220,51,154,4,42,68,195,206,78,17,194,89,123,23,171,23,176,127,208,134,29,227,50,102,19,27,115,105,190,185,48,65,101,22,41,221,214,154,69,127,134,44,162,38,167,137,208,135,102,57,62,242,99,194,146,153,25,23,77,106,172,152,207,55,166,169,209,217,212,228,245,54,224,28,93,101,183,216,120,21,125,130,162,45,88,214,252,135,106,192,214,86,113,82,232,89,66,169,58,171,92,219,123,219,79,70,183,93,44,3,203,127,153,75,115,239,177,202,153,143,97,169,11,215,18,169,17,187,45,16,237,66,19,42,92,248,203,169,13,208,173,214,55,206,204,220,112,159,254,151,129,221,120,100,158,156,87,147,83,167,47,138,153,151,106,197,210,152,139,59,156,235,129,190,81,245,70,163,92,192,71,175,192,18,236,179,91,178,58,213,10,114,241,247,11,134,230,0,38,197,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db016652-cdcd-4970-851f-e074cf62fd10"));
		}

		#endregion

	}

	#endregion

}

