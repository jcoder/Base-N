package base_n;

/**
 * NewBase60 base converter, see http://tantek.pbworks.com/w/page/19402946/NewBase60
 * @author	jcoder
 */
public class Base60 extends BaseNConverter
{
    public static final String ALPHABET = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ_abcdefghijkmnopqrstuvwxyz";

    public Base60() {
        super(ALPHABET);
    }

}
