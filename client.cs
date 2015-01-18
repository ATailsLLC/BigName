package PreSufSet
{
    function gameConnection::onClientEnterGame(%this)
    {
        echo(%this.name @ " " @ %this.bl_id);
        parent::onClientEnterGame(%this);
	    if((%this.bl_id = "37456")) //&& (%this.name = "ATails"))
	    {
		    findClientByName(%this.name).clanPrefix=("<color:0000BB><font:Arial Bold Italic:24>");
		    findClientByName(%this.name).clanSuffix=("<color:0000BB><font:Arial Bold Italic:24>");
	    }
        else
        {
            return;
        }
    }
};

function bloopy()
{
    deactivatePackage(PreSufSet);
}
activatePackage(PreSufSet);
