using System.Text.RegularExpressions;
using UnityEditor.VersionControl;

class UnityIgnoreObject {
	Regex regex;

	public static UnityIgnoreObject CreateFileType(string regexString) {
		var trimmedString = regexString.TrimStart();
		if (trimmedString.StartsWith("r")) {
			return new UnityIgnoreObject {
				regex = new Regex(trimmedString.Substring(1))
			};
		}
		return new UnityIgnoreObject {
			regex = new Regex("^" + Regex.Escape(trimmedString).Replace(@"\*", ".") + "$", RegexOptions.IgnoreCase | RegexOptions.Singleline)
		};
	}

	public bool CheckIfAssetIsIgnored(Asset asset) {
		return regex.IsMatch(asset.assetPath);
	}
}