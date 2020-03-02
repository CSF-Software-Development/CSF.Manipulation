## Abandoned
This project was a set of ideas towards the
creation of a generalised solution for specifying
changes to **business/domain objects**.
The intent was to dynamically generate a subclass/proxy
of the object to be changed, which would present the
same API as the original object. Changes to the state
of this proxy could be tracked and:

* Overlaid into a real object, to provide a preview of
the changed state, without actually changing the real
object.

* Inspected to discover which changes had been made.

* 'Replayed' into the real object instance in order to
make the changes 'for real'.

There is a volume of notes about how I was considering
achieving this [on the wiki for this repository].
Ultimately, I've revisited this a few times and I can't
see a good solution to a number of *fundamental flaws
in the overall concept*. These include:

* Providing a sane API to deal with manipulating collections of objects

* Dealing with the inevitable *split-state* across two separate objects

As such, I've **archived** this repository and won't be spending any more time with it.

[on the wiki for this repository]: https://github.com/csf-dev/CSF.Manipulation/wiki
