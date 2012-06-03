package base_n;

/**
 * Easy access to some predefined converters
 * @author	jcoder
 */
public class BaseNPredefined
{
    private static BaseNConverter binary = new Base2();
    private static BaseNConverter octal = new Base8();
    private static BaseNConverter dec = new Base10();
    private static BaseNConverter hexadec = new Base16();
    private static BaseNConverter sixty = new Base60();

    private BaseNPredefined() { }

    /**
     * Gets a binary converter
     * @return	binary converter
     */
    public static BaseNConverter getBinary()
    {
        return binary;
    }

    /**
     * Gets an octal converter
     * @return	octal converter
     */
    public static BaseNConverter getOctal()
    {
        return octal;
    }

    /**
     * Gets a decimal converter
     * @return	decimal converter
     */
    public static BaseNConverter getDec()
    {
        return dec;
    }

    /**
     * Gets a hexadecimal converter
     * @return	hexadecimal converter
     */
    public static BaseNConverter getHexadec()
    {
        return hexadec;
    }

    /**
     * Gets a NewBase60 converter, see http://tantek.pbworks.com/w/page/19402946/NewBase60 
     * @return	NewBase60 converter
     */
    public static BaseNConverter getSixty()
    {
        return sixty;
    }

}
