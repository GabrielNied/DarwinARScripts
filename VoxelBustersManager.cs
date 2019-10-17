using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VoxelBusters;
using VoxelBusters.NativePlugins;

public class VoxelBustersManager : MonoBehaviour
{
    public eShareOptions[] m_excludedOptions;

    public void ShareScreenShotUsingShareSheet()
    {
        // Create share sheet
        ShareSheet _shareSheet = new ShareSheet();
        //_shareSheet.Text = m_shareMessage;

        // Set this list if you want to exclude any service/application type. Else, ignore.
        _shareSheet.ExcludedShareOptions = m_excludedOptions;

        // Attaching screenshot here
        _shareSheet.AttachScreenShot();

        // Show composer
        NPBinding.UI.SetPopoverPointAtLastTouchPosition();
        NPBinding.Sharing.ShowView(_shareSheet, FinishedSharing);
    }

    void FinishedSharing(eShareResult _result)
    {
        Debug.Log("Finished sharing");
        Debug.Log("Share Result = " + _result);
    }
}