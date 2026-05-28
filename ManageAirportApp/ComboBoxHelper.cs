using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ManageAirportApp
{
    public static class ComboBoxHelper
    {
        private static Dictionary<System.Windows.Forms.ComboBox, List<int>> disabledItemsMap = new Dictionary<System.Windows.Forms.ComboBox, List<int>>();
        private static Dictionary<System.Windows.Forms.ComboBox, int> lastValidSelectedIndexMap = new Dictionary<System.Windows.Forms.ComboBox, int>();

        public static void ConfigureForDisabledItems(this System.Windows.Forms.ComboBox comb)
        {
            if (disabledItemsMap.ContainsKey(comb))
            {
                return;
            }

            comb.DrawItem += ComboBox_DrawItem;
            comb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            comb.DropDownClosed += ComboBox_DropDownClosed;

            disabledItemsMap[comb] = new List<int>();
            lastValidSelectedIndexMap[comb] = -1;

            comb.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public static void DisableItemsFromIndexToEnd(this System.Windows.Forms.ComboBox comb, int startIndex)
        {
            // اطمینان از اینکه ComboBox پیکربندی شده است
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];
            disabledIndexes.Clear(); // پاک کردن لیست قبلی آیتم‌های غیرفعال

            if (startIndex < 0 || startIndex >= comb.Items.Count)
            {
                // اگر startIndex نامعتبر بود، لیست خالی می‌ماند (همه فعال)
                comb.Invalidate(); // برای اطمینان از باز-رسم شدن
                return;
            }

            for (int i = startIndex; i < comb.Items.Count; i++)
            {
                if (!disabledIndexes.Contains(i))
                {
                    disabledIndexes.Add(i);
                }
            }

            comb.Invalidate();
        }

        public static void DisableItemsInRange(this System.Windows.Forms.ComboBox comb, int startIndex, int endIndex)
        {
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];
            disabledIndexes.Clear();

            startIndex = Math.Max(0, startIndex);
            endIndex = Math.Min(comb.Items.Count - 1, endIndex);

            if (startIndex > endIndex) return;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (!disabledIndexes.Contains(i))
                {
                    disabledIndexes.Add(i);
                }
            }
            comb.Invalidate();
        }

      
        public static void DisableItem(this System.Windows.Forms.ComboBox comb, int itemIndex)
        {
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];

            if (itemIndex >= 0 && itemIndex < comb.Items.Count && !disabledIndexes.Contains(itemIndex))
            {
                disabledIndexes.Add(itemIndex);
                comb.Invalidate();
            }
        }

        public static void EnableItem(this System.Windows.Forms.ComboBox comb, int itemIndex)
        {
            if (!disabledItemsMap.ContainsKey(comb)) return;

            List<int> disabledIndexes = disabledItemsMap[comb];

            if (disabledIndexes.Contains(itemIndex))
            {
                disabledIndexes.Remove(itemIndex);
                comb.Invalidate();
            }
        }

        public static void EnableAllItems(this System.Windows.Forms.ComboBox comb)
        {
            if (!disabledItemsMap.ContainsKey(comb)) return;

            disabledItemsMap[comb].Clear();
            comb.Invalidate();
        }


        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null || e.Index < 0) return;

            if (!disabledItemsMap.ContainsKey(comb))
            {
                e.DrawBackground();
                e.Graphics.DrawString(comb.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Location);
                e.DrawFocusRectangle();
                return;
            }

            List<int> disabledIndexes = disabledItemsMap[comb];
            bool isDisabled = disabledIndexes.Contains(e.Index);

            using (Brush textBrush = new SolidBrush(isDisabled ? Color.Gray : e.ForeColor))
            {
                e.DrawBackground();
                e.Graphics.DrawString(comb.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds.Location);
                e.DrawFocusRectangle();
            }
        }

        private static void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null) return;

            if (!disabledItemsMap.ContainsKey(comb)) return;

            int currentSelectedIndex = comb.SelectedIndex;
            List<int> disabledIndexes = disabledItemsMap[comb];
            int lastValidIndex = lastValidSelectedIndexMap[comb];

            if (currentSelectedIndex >= 0 && disabledIndexes.Contains(currentSelectedIndex))
            {
                comb.SelectedIndex = lastValidIndex;

                }
            else if (currentSelectedIndex >= 0)
            {
               
                lastValidSelectedIndexMap[comb] = currentSelectedIndex;
            }
            else
            {
               
                if (lastValidIndex != -1 && !disabledIndexes.Contains(lastValidIndex))
                {
                    
                }
                else if (comb.Items.Count > 0 && !disabledIndexes.Contains(0))
                {
                   
                    lastValidIndex = 0;
                    lastValidSelectedIndexMap[comb] = lastValidIndex;
                    comb.SelectedIndex = lastValidIndex;
                }
                else
                {
                    lastValidSelectedIndexMap[comb] = -1;
                }
            }
        }

        private static void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null) return;

            if (!disabledItemsMap.ContainsKey(comb)) return;

            int lastValidIndex = lastValidSelectedIndexMap[comb];
            List<int> disabledIndexes = disabledItemsMap[comb];

            if (lastValidIndex != -1 && disabledIndexes.Contains(lastValidIndex))
            {
                int firstEnabledIndex = comb.Items.Cast<object>().Select((item, index) => new { item, index })
                                        .FirstOrDefault(x => !disabledIndexes.Contains(x.index))?.index ?? -1;

                if (firstEnabledIndex != -1)
                {
                    lastValidSelectedIndexMap[comb] = firstEnabledIndex;
                    comb.SelectedIndex = firstEnabledIndex;
                }
                else
                {
                    lastValidSelectedIndexMap[comb] = -1;
                    comb.SelectedIndex = -1; 
                }
            }
            else if (lastValidIndex == -1 && comb.Items.Count > 0 && !disabledIndexes.Contains(0))
            {
                lastValidSelectedIndexMap[comb] = 0;
                comb.SelectedIndex = 0;
            }
        }
    }
}
