﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationCleanerJobSchema

	/// <exclude/>
	public class NotificationCleanerJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationCleanerJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationCleanerJobSchema(NotificationCleanerJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2475ae6-5dca-4df6-8e55-ecfad8bf19a5");
			Name = "NotificationCleanerJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,87,75,111,219,56,16,62,171,64,255,3,161,94,36,192,149,11,236,173,117,13,184,142,29,184,216,62,182,206,238,30,11,70,26,39,44,36,202,225,195,141,177,216,255,190,35,82,178,72,61,226,160,155,221,230,224,136,228,204,112,30,223,124,36,57,45,64,238,105,10,228,10,132,160,178,220,169,100,89,242,29,187,209,130,42,86,242,231,207,254,122,254,44,208,146,241,27,178,61,74,5,197,155,206,24,229,243,28,210,74,88,38,151,192,65,176,180,149,113,205,10,24,155,79,46,222,141,46,109,211,91,200,116,14,2,37,80,230,133,128,27,220,138,44,115,42,229,107,242,177,84,108,199,82,227,235,50,7,138,219,191,47,175,141,228,116,58,37,51,169,139,130,138,227,188,30,27,45,178,43,5,225,142,34,73,43,77,220,59,105,212,166,142,222,94,95,231,44,69,153,74,117,120,63,242,154,108,240,223,234,30,82,173,74,129,74,85,214,78,190,174,25,228,25,58,251,89,176,3,85,96,188,11,246,118,64,46,240,231,138,21,64,190,22,140,87,131,55,238,234,239,18,4,22,132,219,4,147,175,218,27,123,162,41,22,64,17,198,21,185,128,29,213,185,250,64,239,23,55,176,65,163,71,73,222,146,95,94,217,12,6,47,128,103,214,179,122,92,187,249,1,212,109,57,234,231,161,100,25,90,206,65,193,23,64,87,51,204,151,140,98,98,34,13,14,84,144,204,44,254,166,65,28,113,59,14,223,107,241,168,227,117,108,52,130,100,45,202,34,10,79,198,194,152,80,89,171,152,192,130,69,150,173,89,174,64,200,200,177,29,219,69,103,38,177,137,135,200,46,253,61,234,248,74,242,39,245,125,181,253,232,2,98,48,2,220,243,105,131,88,112,206,14,104,14,225,249,63,22,194,236,250,131,129,4,193,57,32,173,75,177,102,156,73,108,245,5,186,118,96,234,232,69,180,235,44,174,238,153,84,114,11,21,241,52,113,94,130,234,218,232,137,213,62,61,77,150,234,249,63,111,65,64,20,186,64,184,58,238,97,147,133,113,178,145,171,59,77,243,8,57,82,23,60,249,76,5,18,46,166,48,58,153,89,86,93,43,147,174,246,105,125,147,197,205,70,11,158,69,205,183,141,44,58,155,151,127,131,179,60,31,192,87,197,47,133,79,44,134,166,189,83,35,193,163,97,11,74,85,154,120,38,168,63,104,174,97,134,170,243,110,114,39,54,30,47,123,114,117,191,103,214,16,158,5,69,56,25,34,180,58,176,134,52,209,141,134,72,49,151,223,19,68,108,37,21,189,44,250,58,125,18,115,231,59,28,225,46,141,116,222,160,213,65,68,143,102,28,221,109,53,235,38,179,6,93,152,78,200,165,70,97,222,67,90,83,28,71,214,7,103,139,218,9,169,7,85,170,26,12,7,8,212,95,65,202,62,78,155,252,122,32,244,205,13,1,191,53,59,130,255,129,24,6,179,99,161,252,200,222,174,179,32,64,105,193,73,100,215,226,170,179,237,231,88,103,91,239,26,39,77,71,70,92,231,121,28,39,11,137,157,141,159,139,156,81,25,250,84,208,120,82,245,57,55,23,1,198,219,217,173,162,74,163,74,242,169,63,137,89,243,232,161,53,133,43,86,166,205,98,83,195,190,13,155,146,135,104,70,9,221,41,157,187,147,239,131,87,212,173,190,254,134,73,170,36,124,22,127,196,229,161,84,168,9,153,93,239,222,194,204,4,114,131,36,2,238,52,224,141,101,103,241,158,156,164,167,93,241,217,190,10,136,112,12,234,109,232,96,60,156,215,61,114,103,136,109,54,53,114,115,139,159,218,11,114,96,66,97,124,167,62,27,111,175,6,63,67,205,232,117,225,57,242,118,199,8,236,62,5,247,155,104,35,191,0,125,240,196,176,165,116,123,100,60,181,180,37,170,159,149,102,239,190,240,31,230,218,225,228,38,213,103,211,131,215,182,159,149,22,231,54,56,158,148,81,26,239,222,55,17,56,75,1,200,147,217,39,254,163,92,62,96,179,1,227,89,22,239,99,242,60,61,152,215,212,3,21,170,175,39,242,244,40,35,223,202,235,199,150,199,231,247,112,94,61,159,170,135,81,61,225,21,169,167,188,111,226,146,225,252,20,163,244,11,107,223,130,166,154,205,61,170,243,68,235,220,111,200,230,130,153,47,244,121,38,149,192,128,38,164,52,228,58,39,237,142,77,233,59,39,20,94,107,6,94,124,193,224,5,109,172,12,245,156,59,101,102,240,239,31,43,238,91,133,255,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2475ae6-5dca-4df6-8e55-ecfad8bf19a5"));
		}

		#endregion

	}

	#endregion

}

