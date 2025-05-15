using System;
using System.Text;

using UnityEngine;
using Color = UnityEngine.Color;

namespace Utility
{
    public static class StringUtil
    {
        #region RichText


        /// The methods in this region work with the unity's UI/Legacy/Text aka unity old text interface before text mesh pro
        /// TextMeshPro is compatible with all but "addMaterialToString" and "addQuadToString"
        #region UnityLegacyCompatible
        /// <summary>
        /// Change the size of the text
        /// </summary>
        /// <param name="input"></param>
        /// <param name="size">How big or small the text is going to be</param>
        /// <see cref="http://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
        /// <returns>Whatever input is but with a different size</returns>
        public static string addSizeToString(string input, int size) => addTagWithValueToString(input, "size", size);

        /// <summary>
        ///  Makes the input text <i>Italic</i> 
        /// </summary>
        /// <param name="input">The text to be encapsulated by the tag </param>
        /// <see cref="http://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
        /// <returns> whatever 'input' is but in <i>Italics</i></returns>
        public static string addItalicsToString(string input) => addTagToString(input, "i");

        /// <summary>
        ///  Makes the input text <b>Bold</b>
        /// </summary>
        /// <param name="input">The text to be encapsulated by the tag </param>
        /// <see cref="http://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
        /// <returns> whatever 'input' is but in <b>Bold</b></returns>
        public static string addBoldToString(string input) => addTagToString(input, "b");

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>THIS ONLY WORK ON THE UNITY LEGACY UI TEXT textMeshPro can do the same but in a different way</remarks>
        /// <param name="input">The text to be encapsulated by the tag </param>
        /// <param name="material_index">The index of the material</param>
        /// <see cref="http://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
        /// <returns></returns>
        public static string addMaterialToString(string input, int material_index) => addTagWithValueToString(input, "material", material_index);

        /// <summary>
        /// Add the quad tag to the input plus the attributes of the quad itself
        /// </summary>
        /// <remarks>THIS ONLY WORK ON THE UNITY LEGACY UI TEXT </remarks>
        /// <param name="input">The text to be encapsulated by the tag </param>
        /// <param name="quad_attributes">In unity they are can be something like "material=1 size=12 x=0.1 y=0.1 width=10 height=12" or whatever value you like</param>
        /// <see cref="http://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
        /// <returns>The string after being formated </returns>
        public static string addQuadToString(string input, string quad_attributes) => $"<quad {quad_attributes}>{input}</quad>";

        /// <summary>
        /// Adds color to the given input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="color"></param>
        /// <returns>The input but encapsulated in color tag</returns>
        public static string addColorToString(string input, Color color) => $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{input}</color>";

        #endregion

        #region TextMeshPro

        /// <summary>
        /// Change the alpha of the given text
        /// </summary>
        /// <remarks> this does not work with unity legacy text</remarks>
        /// <param name="input"></param>
        /// <param name="alpha_value"></param>
        /// <returns></returns>
        public static string addAlphaToString(string input, byte alpha_value) => $"<alpha=#{alpha_value.ToString("X")}>{input}";

        /// <summary>
        /// Inserts the tag 'alpha' somewhere in the input
        /// </summary>
        /// <remarks>The alpha tag is meant to be inserted in multiple places that is why this method exist</remarks>
        /// <param name="input">the original text </param>
        /// <param name="index">where to insert the new text</param>
        /// <param name="alpha_value"> how much alpha do you want</param>
        /// <see cref="http://digitalnativestudios.com/textmeshpro/docs/rich-text/#color"/>
        /// <returns>the input with the alpha tag inserted </returns>
        public static string insertAlphaToString(string input, int index, byte alpha_value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            sb.Insert(index,$"<alpha=#{alpha_value.ToString("X")}>");
            return sb.ToString();
        }

        public static string addAlignLeftToString(string input) => addTagWithQuoteToString(input, "align", "left");
        public static string addAlignCenterToString(string input) => addTagWithQuoteToString(input, "align", "center");
        public static string addAlignRightToString(string input) => addTagWithQuoteToString(input, "align", "right");

        #endregion


        #endregion

        #region RepeatedLogic
        /// <summary>
        /// The logic for adding a tag to a string
        /// </summary>
        /// <param name="input"> the original input</param>
        /// <param name="tag"> the Tag we are going to use on it</param>
        /// <returns> $"<{tag}>{input}</{tag}>" </returns>
        public static string addTagToString(string input, string tag) => $"<{tag}>{input}</{tag}>";

        /// <summary>
        /// The logic for adding a tag with a numerical argument
        /// </summary>
        /// <param name="input"> the original input</param>
        /// <param name="tag"> the Tag we are going to use on it</param>
        /// <param name="value">The numerical value</param>
        /// <returns>$"<{tag}={value}>{input}</{tag}>"</returns>
        public static string addTagWithValueToString(string input, string tag, int value) => $"<{tag}={value}>{input}</{tag}>";

        /// <summary>
        /// The logic for a adding a tag with a value encapsulated in quotes
        /// </summary>
        /// <param name="input"> the original input</param>
        /// <param name="tag"> the Tag we are going to use on it</param>
        /// <param name="quoted">The value that is quoted</param>
        /// <returns>$"<{tag}=\"{quoted}\">{input}</{tag}>"</returns>
        public static string addTagWithQuoteToString(string input, string tag, string quoted) => $"<{tag}=\"{quoted}\">{input}</{tag}>";
        #endregion

    }
}