﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkingDayCountTermSchema

	/// <exclude/>
	public class WorkingDayCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkingDayCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkingDayCountTermSchema(WorkingDayCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2360fa7-9b78-4b00-93bb-04fa3ca5e42c");
			Name = "WorkingDayCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,193,110,227,54,16,61,59,192,254,195,172,247,34,99,183,114,114,221,216,46,82,39,187,8,176,105,22,112,138,28,138,30,24,137,182,137,72,164,74,82,113,220,32,255,222,33,41,82,180,44,59,69,209,238,33,142,68,205,112,222,204,188,121,36,39,37,85,21,201,40,220,81,41,137,18,75,157,206,5,95,178,85,45,137,102,130,167,115,82,80,158,19,169,222,157,188,188,59,25,212,138,241,21,92,61,107,202,21,126,86,231,97,109,177,85,154,150,221,119,220,173,40,104,102,182,82,233,87,202,169,100,217,158,205,55,198,255,108,23,15,32,65,3,52,249,32,233,10,95,96,94,16,165,224,51,220,11,249,136,78,151,100,59,23,53,215,232,91,90,187,241,120,12,19,85,151,37,145,219,89,243,110,45,64,163,9,60,108,97,227,60,33,39,91,149,122,143,113,228,82,213,15,5,203,32,179,145,122,226,96,244,95,136,162,81,220,193,139,141,29,64,222,80,189,22,185,250,12,223,165,208,88,4,154,187,239,149,127,5,241,132,201,178,156,194,147,96,57,124,19,43,44,119,86,23,54,225,107,142,80,159,72,161,146,235,43,94,151,84,146,135,130,78,174,125,67,16,202,204,130,255,4,185,64,168,20,52,43,233,69,105,224,140,192,244,106,48,96,75,72,12,180,104,87,140,177,208,66,82,120,63,5,94,23,133,55,29,112,186,129,125,219,21,149,135,118,24,57,191,65,250,133,21,69,91,31,213,147,66,226,112,70,0,207,173,243,171,249,125,237,22,197,215,226,11,147,74,247,237,22,215,192,148,224,199,166,123,145,231,22,217,175,130,55,89,31,200,184,39,201,15,8,219,145,163,151,41,72,169,239,150,117,238,107,151,196,118,225,43,213,10,244,154,194,134,210,71,5,164,116,172,22,176,50,211,69,52,77,131,235,184,235,59,169,136,36,37,112,156,250,233,208,244,100,56,243,165,116,115,48,25,91,139,195,14,174,125,195,217,29,2,200,188,171,195,176,239,44,169,174,37,87,51,231,4,98,233,48,163,161,255,18,76,233,115,70,43,83,64,200,36,93,78,135,23,114,133,148,231,250,202,175,219,144,216,71,130,127,92,236,78,239,100,28,220,237,142,205,228,134,225,98,24,28,203,118,111,130,219,113,125,115,162,140,71,155,110,224,23,174,110,90,162,195,212,133,119,91,226,35,76,103,240,30,255,167,215,170,37,71,195,2,195,205,29,223,41,156,6,50,234,181,20,27,48,148,220,203,59,25,30,206,123,24,51,108,240,132,157,216,132,20,17,92,114,150,195,199,40,13,24,199,232,27,95,215,9,72,48,183,81,114,67,244,58,157,83,86,160,77,210,238,53,114,182,175,71,88,121,145,233,154,20,236,175,136,21,38,48,44,133,52,43,126,60,254,71,110,106,122,135,242,98,157,124,52,168,216,147,216,229,101,151,26,86,107,2,120,83,151,4,249,7,111,241,227,178,9,7,62,174,111,101,87,154,60,71,172,98,220,202,75,186,36,117,129,100,49,84,201,211,214,216,237,146,154,7,67,141,60,94,136,24,100,200,213,240,42,28,15,105,211,239,152,80,174,171,49,59,204,110,139,138,112,80,154,72,237,157,29,188,253,45,111,24,79,152,193,200,210,133,177,223,129,208,64,51,63,183,75,147,231,108,119,211,128,226,152,134,183,250,56,200,163,89,114,188,79,112,20,126,255,3,94,108,5,95,123,116,180,151,131,62,76,219,21,115,206,123,62,254,16,89,180,163,221,74,178,103,62,61,172,141,33,144,57,28,59,202,216,37,107,96,93,200,244,95,10,217,161,139,70,115,157,104,237,207,131,178,224,45,72,95,182,124,190,55,162,116,88,243,210,197,35,171,146,72,122,126,130,179,145,27,130,36,218,20,209,222,46,219,171,131,205,109,234,67,245,176,146,60,39,27,75,203,13,75,175,120,190,43,97,222,173,119,168,204,169,157,244,132,123,91,217,194,121,107,26,4,53,103,90,253,83,42,121,234,237,30,151,199,217,84,225,13,25,111,2,206,165,121,57,204,158,187,128,9,178,230,12,62,70,160,230,32,52,94,191,25,167,246,38,213,33,143,199,250,105,71,9,125,69,125,71,102,30,160,231,149,233,169,164,10,21,14,219,120,234,186,131,39,0,37,217,26,18,243,177,66,8,93,39,235,213,104,64,168,17,162,180,98,172,215,12,25,89,57,21,50,15,109,219,251,104,217,149,217,227,103,242,127,200,193,65,147,246,199,169,195,24,169,227,164,55,196,207,112,138,183,189,179,88,162,27,30,187,157,98,94,118,110,141,110,117,119,17,215,78,78,254,6,188,68,173,224,206,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2360fa7-9b78-4b00-93bb-04fa3ca5e42c"));
		}

		#endregion

	}

	#endregion

}

